using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppImportaciones.Controllers;

namespace AppImportaciones.Views
{
    public partial class ListPais : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Helpers.precargarDatos();
            cargarGrid();
        }

        //Cargar listado de paises
        public void cargarGrid()
        {
            grdPais.DataSource = PaisController.getPais();
            grdPais.DataBind();
        }

        protected void lnkAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddPais.aspx");
        }
    }
}