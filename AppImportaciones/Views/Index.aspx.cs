using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppImportaciones.Views
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void lnkUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListUsuario.aspx");
        }

        protected void lnkPais_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListPais.aspx");
        }

        protected void lnkCiudad_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListCiudad.aspx");
        }

        protected void lnkProducto_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListProducto.aspx");
        }
    }
}