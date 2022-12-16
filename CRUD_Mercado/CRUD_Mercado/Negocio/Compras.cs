using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_Mercado.Negocio
{
    public class Compras
    {
        private MySqlConnection connection;
        public Compras()
        {
            connection = new MySqlConnection(SiteMaster.ConnectionString);
        }
    }
}