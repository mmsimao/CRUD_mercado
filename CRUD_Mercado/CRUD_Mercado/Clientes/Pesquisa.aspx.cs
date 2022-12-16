using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD_Mercado.clientes
{
    public partial class Pesquisa : System.Web.UI.Page
    {
        private object compras;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void pesquisar_Click(object sender, EventArgs e)
        {
            var clientes = new Negocio.Clientes().Read(ID, cliente.Text, compras);
            Session["dados"] = clientes;
            grdClientes.DataSource = clientes;
            grdClientes.DataBind();
        }

        protected void grdClientes_RowCommand(Object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            var clientes = (List<Classes.Clientes>)Session["dados"];

            if (e.CommandName == "excluir")
            {
            }

            if (e.CommandName == "editar")
            {
                Response.Redirect("Editar.aspx?id=" + clientes[index].ID);
            }
        }
    }
}