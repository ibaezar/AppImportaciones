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

            if (!IsPostBack)
            {
                cargarDrop();
            }

        }

        public void cargarDrop()
        {
            dropPais.DataSource = from p in PaisController.getPais()
                                  select new
                                  {
                                      id = p.idPais,
                                      nombre = p.nombrePais
                                  };
            dropPais.DataValueField = "id";
            dropPais.DataTextField = "nombre";
            dropPais.DataBind();

        }

        public string cargarGrid()
        {
            try
            {

                grdCiudad.DataSource = from c in CiudadController.getListado(dropPais.SelectedValue)
                                       select new
                                       {
                                           Ciudades = c.nombreCiudad
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