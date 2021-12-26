using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppImportaciones.Controllers;

namespace AppImportaciones.Views
{
    public partial class DeleteProducto : System.Web.UI.Page
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
            dropProductos.DataSource = from p in ProductoController.GetProductos()
                                  select new
                                  {
                                      id = p.idProducto,
                                      nombre = p.nombreProducto
                                  };
            dropProductos.DataValueField = "id";
            dropProductos.DataTextField = "nombre";
            dropProductos.DataBind();

        }

        protected void lnkEliminar_Click(object sender, EventArgs e)
        {
            lbMensaje.Text = ProductoController.deleteProducto(dropProductos.SelectedValue);
            cargarDrop();
        }

        protected void lnkListar_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            Response.Redirect("ListProducto.aspx");
        }

        protected void lnkAgregar_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            Response.Redirect("AddProducto.aspx");
        }
    }
}