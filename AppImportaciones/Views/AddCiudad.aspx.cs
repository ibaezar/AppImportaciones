using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppImportaciones.Controllers;
using AppImportaciones.Models;

namespace AppImportaciones.Views
{
    public partial class AddCiudad1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Helpers.precargarDatos();

            //Validacion de usuario administrador
            if (Session["login"] != null)
            {
                Usuario usr = (Usuario)Session["login"];
                if (usr.Rol != "Administrador")
                {
                    Response.Redirect("index.aspx");
                }
            }
            else
            {
                Response.Redirect("index.aspx");
            }
            //Fin validacion

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
            System.Threading.Thread.Sleep(2000);
            lbMensaje.Text = CiudadController.addCiudad(txtId.Text, txtNombre.Text, dropPais.SelectedValue);
        }

        protected void lnkListar_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            Response.Redirect("ListCiudad.aspx");
        }
    }
}