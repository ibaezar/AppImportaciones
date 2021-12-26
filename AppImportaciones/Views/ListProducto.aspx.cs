using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppImportaciones.Controllers;

namespace AppImportaciones.Views
{
    public partial class ListProducto1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGrid();
            }
        }

        public void cargarGrid()
        {
            grdProducto.DataSource = from p in ProductoController.GetProductos()
                                     select new
                                     {
                                         Producto = p.nombreProducto,
                                         Valor = p.valor,
                                         Stock = p.stock
                                     };
            grdProducto.DataBind();
        }

        protected void lnkAgregar_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            Response.Redirect("AddProducto.aspx");
        }

        protected void lnkEliminar_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            Response.Redirect("DeleteProducto.aspx");
        }
    }
}