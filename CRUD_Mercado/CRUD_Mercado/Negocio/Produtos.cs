using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_Mercado.Negocio
{
    public class Produtos
    {
        private MySqlConnection connection;
        public Produtos()
        {
            connection = new MySqlConnection(SiteMaster.ConnectionString);
        }
    }
}