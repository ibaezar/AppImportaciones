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

                UsuarioController.cargarRol();
                cargarDropRol();
                cargarDropPais();
                cargarDropCiudad();
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
                                      id = p.idPais,
                                      Pais = p.nombrePais
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
                                        id = c.idCiudad,
                                        ciudad = c.nombreCiudad
                                    };
            dropCiudad.DataValueField = "id";
            dropCiudad.DataTextField = "ciudad";
            dropCiudad.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            try
            {
                lbMensaje.Text = UsuarioController.addUsuario(txtNombre.Text, txtAp1.Text, txtAp2.Text, txtFecha.Text, dropRol.SelectedValue, txtEmail.Text, txtNum.Text, dropPais.SelectedValue, dropCiudad.SelectedValue, txtPassword.Text);

                //Limpiar campos
                txtNombre.Text = "";
                txtAp1.Text = "";
                txtAp2.Text = "";
                txtFecha.Text = "";
                txtEmail.Text = "";
                txtNum.Text = "";
                txtPassword.Text = "";
                txtRepetirPassword.Text = "";
            }
            catch (Exception ex)
            {

                lbMensaje.Text = "Error: " + ex;
            }
        }

        protected void lnkListar_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            Response.Redirect("ListUsuario.aspx");
        }

        protected void dropPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDropCiudad();
        }
    }
}