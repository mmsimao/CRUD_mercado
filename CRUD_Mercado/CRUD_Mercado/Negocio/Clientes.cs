using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySqlConnector;

namespace CRUD_Mercado.Negocio
{
    public class Clientes
    {
        private MySqlConnection connection;
        public Clientes()
        {
            connection = new MySqlConnection(SiteMaster.ConnectionString);
        }

        public Classes.Clientes Read(string id)
        {
            return this.Read(id, "", "").FirstOrDefault();
        }

        internal object Read(string v, string text, object compras)
        {
            throw new NotImplementedException();
        }

        public List<Classes.Clientes> Read(string ID, string nome, string compras)
        {
            var clientes = new List<Classes.Clientes>();
            try
            {
                connection.Open();
                var commando = new MySqlCommand($"SELECT nome, compras, ID FROM clientes WHERE (1=1) ", connection);
                if (nome.Equals("") == false)
                {
                    commando.CommandText += $" AND nome like @nome";
                    commando.Parameters.Add(new MySqlParameter("nome", $"%{nome}%"));
                }
                if (compras.Equals("") == false)
                {
                    commando.CommandText += $" AND compras = @compras";
                    commando.Parameters.Add(new MySqlParameter("compras", compras));
                }
                if (ID.Equals("") == false)
                {
                    commando.CommandText += $" AND ID = @ID";
                    commando.Parameters.Add(new MySqlParameter("ID", ID));
                }
                var reader = commando.ExecuteReader();
                while (reader.Read())
                {
                    clientes.Add(new Classes.Clientes
                    {
                        nome = reader.GetString("nome"),
                        compras = reader.GetInt32("compras"),
                        ID = reader.GetInt32("ID")
                    });
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return clientes;
        }

        public bool Create(Classes.Clientes clientes)
        {
            try
            {
                connection.Open();
                var comando = new MySqlCommand($@"INSERT INTO clientes (nome) VALUES (@nome)", connection);
                comando.Parameters.Add(new MySqlParameter("nome", clientes.nome));
                comando.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Update(Classes.Clientes clientes)
        {
            try
            {
                connection.Open();
                var comando = new MySqlCommand($@"UPDATE clientes SET nome = @nome, compras = @compras WHERE ID = @ID", connection);
                comando.Parameters.Add(new MySqlParameter("nome", clientes.nome));
                comando.Parameters.Add(new MySqlParameter("compras", clientes.compras));
                comando.Parameters.Add(new MySqlParameter("ID", clientes.ID));
                comando.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Delete(int ID)
        {
            try
            {
                connection.Open();
                var comando = new MySqlCommand("DELETE FROM clientes WHERE ID = " + ID, connection);
                comando.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}