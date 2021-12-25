using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppImportaciones.Controllers;

namespace AppImportaciones.Views
{
    public partial class AddProducto1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Validacion de usuario administrador
            if (Session["login"] != null)
            {
                Usuario usr = (Usuario)Session["login"];
                if (usr.rol != "Administrador" && usr.rol != "Vendedor")
                {
                    Response.Redirect("index.aspx");
                }
            }
            else
            {
                Response.Redirect("index.aspx");
            }
            //Fin validacion
        }

        protected void lnkAgregar_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            lbMensaje.Text = ProductoController.addProducto(txtNombre.Text, txtValor.Text, txtStock.Text);
            
            //Limpiar campos
            txtNombre.Text = "";
            txtStock.Text = "";
            txtValor.Text = "";
        }

        protected void lnkListar_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            Response.Redirect("ListProducto.aspx");
        }
    }
}