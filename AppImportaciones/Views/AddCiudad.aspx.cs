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
            //Validacion de usuario administrador
            if (Session["login"] != null)
            {
                Usuario usr = (Usuario)Session["login"];
                if (usr.rol != "Administrador")
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
                                      id = p.idPais,
                                      nombre = p.nombrePais
                                  };
            dropPais.DataValueField = "id";
            dropPais.DataTextField = "nombre";
            dropPais.DataBind();

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            lbMensaje.Text = CiudadController.addCiudad(txtNombre.Text, dropPais.SelectedValue);
            txtNombre.Text = "";
        }

        protected void lnkListar_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            Response.Redirect("ListCiudad.aspx");
        }
    }
}