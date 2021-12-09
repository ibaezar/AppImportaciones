using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppImportaciones.Controllers;

namespace AppImportaciones.Views
{
    public partial class AddUsuario1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Precarga de datos
                Helpers.precargarDatos();


                cargarDropRol();
                cargarDropPais();
            }
        }

        public void cargarDropRol()
        {
            dropRol.DataSource = UsuarioController.getRol();
            dropRol.DataBind();

        }

        public void cargarDropPais()
        {
            dropPais.DataSource = from p in PaisController.getPais()
                                  select new
                                  {
                                      id = p.Idpais,
                                      Pais = p.NombrePais
                                  };
            dropPais.DataValueField = "id";
            dropPais.DataTextField = "Pais";
            dropPais.DataBind();
        }

        public void cargarDropCiudad()
        {
            dropCiudad.DataSource = from c in CiudadController.getListado(dropPais.SelectedValue)
                                    select new
                                    {
                                        ciudad = c.NombreCiudad
                                    };
            dropCiudad.DataTextField = "ciudad";
            dropCiudad.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                lbMensaje.Text = UsuarioController.addUsuario(txtId.Text, txtNombre.Text, txtAp1.Text, txtAp2.Text, txtFecha.Text, dropRol.SelectedValue, txtEmail.Text, txtNum.Text, dropPais.SelectedValue, dropCiudad.SelectedValue, txtPassword.Text);
            }
            catch (Exception ex)
            {

                lbMensaje.Text = "Error: " + ex;
            }
        }

        protected void lnkSeleccionar_Click(object sender, EventArgs e)
        {
            dropCiudad.Enabled = true;
            cargarDropCiudad();
        }

        protected void lnkListar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListUsuario.aspx");
        }
    }
}