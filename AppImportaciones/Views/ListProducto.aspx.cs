﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppImportaciones.Controllers;

namespace AppImportaciones.Views
{
    public partial class ListProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Helpers.precargarDatos();
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
                                         Producto = p.NombreProducto,
                                         Valor = p.Valor,
                                         Stock = p.Stock,
                                         CodigoVendedor = p.CodigoVendedor
                                     };
            grdProducto.DataBind();
        }

        protected void lnkAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddProducto.aspx");
        }
    }
}