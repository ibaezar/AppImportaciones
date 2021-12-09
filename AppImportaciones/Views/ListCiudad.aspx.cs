using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppImportaciones.Controllers;

namespace AppImportaciones.Views
{
    public partial class ListCiudad1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Helpers.precargarDatos();

            if (!IsPostBack)
            {
                cargarDrop();
                cargarGrid();
            }

        }

        public void cargarDrop()
        {
            dropPais.DataSource = from p in PaisController.getPais()
                                  select new
                                  {
                                      id = p.Idpais,
                                      nombre = p.NombrePais
                                  };
            dropPais.DataValueField = "id";
            dropPais.DataTextField = "nombre";
            dropPais.DataBind();

        }

        public string cargarGrid()
        {
            grdCiudad.DataSource = null;
            grdCiudad.DataBind();

            try
            {

                grdCiudad.DataSource = from c in CiudadController.getListado(dropPais.SelectedValue)
                                       select new
                                       {
                                           Ciudad = c.NombreCiudad
                                       };

                grdCiudad.DataBind();
                return "todo OK";
            }
            catch (Exception e)
            {
                return "Error: " + e;
            }
        }

        protected void lnkAgregar_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            Response.Redirect("AddCiudad.aspx");
        }

        protected void lnkVer_Click(object sender, EventArgs e)
        {
            cargarGrid();
        }
    }
}