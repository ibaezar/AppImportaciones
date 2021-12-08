using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppImportaciones.Controllers;

namespace AppImportaciones.Views
{
    public partial class ListUsuario1 : System.Web.UI.Page
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
            grdUsuarios.DataSource = from u in UsuarioController.getUsers()
                                     select new
                                     {
                                         Nombre = u.Nombre,
                                         ApellidoPaterno = u.PrimerApellido,
                                         ApellidoMaterno = u.SegundoApellido,
                                         Rol = u.Rol,
                                         FechaNacimiento = u.FechaNacimiento,
                                         Email = u.Email,
                                         Pais = u.Pais,
                                         Ciudad = u.Ciudad
                                     };
            grdUsuarios.DataBind();

        }

        protected void lnkAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddUsuario.aspx");
        }
    }
}