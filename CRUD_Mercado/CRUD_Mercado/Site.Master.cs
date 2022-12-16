using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD_Mercado
{
    public partial class SiteMaster : MasterPage
    {
        public static string ConnectionString = "Server=127.0.0.1;User ID=root;Password=;Database=mercado";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}