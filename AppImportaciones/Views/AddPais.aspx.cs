﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppImportaciones.Controllers;

namespace AppImportaciones.Views
{
    public partial class AddPais : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkAgregar_Click(object sender, EventArgs e)
        {
            lbMensaje.Text = PaisController.addPais(txtId.Text, txtNombre.Text);
        }

        protected void lnkListado_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListPais.aspx");
        }
    }
}