using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppImportaciones.Controllers;

namespace AppImportaciones.Views
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var usuario in UsuarioController.getUsers())
                {
                    if (usuario.email.Equals(txtEmail.Text))
                    {
                        if (usuario.password.Equals(txtPassword.Text))
                        {
                            Session["login"] = usuario;
                            Response.Redirect("ListUsuario.aspx");
                        }
                        else
                        {
                            Session["login"] = null;
                            Session["Error"] = "Usuario o contraseña incorrectos";
                            lbMensaje.Text = Session["error"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                lbMensaje.Text = "Error: " + ex.Message;
            }
        }
    }
}