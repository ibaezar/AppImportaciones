using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppImportaciones.Controllers;

namespace AppImportaciones.Views
{
    public partial class AddCiudad1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Helpers.precargarDatos();
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
                                      id = p.Idpais,
                                      nombre = p.NombrePais
                                  };
            dropPais.DataValueField = "id";
            dropPais.DataTextField = "nombre";
            dropPais.DataBind();

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            lbMensaje.Text = CiudadController.addCiudad(txtId.Text, txtNombre.Text, dropPais.SelectedValue);
        }

        protected void lnkListar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListCiudad.aspx");
        }
    }
}