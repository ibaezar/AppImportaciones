﻿using System;
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

            if (!IsPostBack)
            {
                cargarDropVendedor();
            }
        }

        public void cargarDropVendedor()
        {
            dropVendedor.DataSource = from v in UsuarioController.getUserByRol("Vendedor")
                                      select new
                                      {
                                          id = v.idUsuario,
                                          nombre = v.nombre + " " + v.primerApellido
                                      };
            dropVendedor.DataValueField = "id";
            dropVendedor.DataTextField = "nombre";
            dropVendedor.DataBind();
        }

        protected void lnkAgregar_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            lbMensaje.Text = ProductoController.addProducto(txtId.Text, txtNombre.Text, txtValor.Text, txtStock.Text, dropVendedor.SelectedValue);
        }

        protected void lnkListar_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            Response.Redirect("ListProducto.aspx");
        }
    }
}