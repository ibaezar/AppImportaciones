using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppImportaciones.Controllers;

namespace AppImportaciones.Views
{
    public partial class ListPais1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
            System.Threading.Thread.Sleep(2000);
            Response.Redirect("AddPais.aspx");
        }
    }
}