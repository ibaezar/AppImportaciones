using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppImportaciones.Controllers;
using AppImportaciones.Models;

namespace AppImportaciones.Views
{
    public partial class ListUsuario1 : System.Web.UI.Page
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
                cargarGrid();
            }
        }

        public void cargarGrid()
        {
            grdUsuarios.DataSource = from u in UsuarioController.getUsers()
                                     select new
                                     {
                                         Nombre = u.nombre,
                                         ApellidoPaterno = u.primerApellido,
                                         ApellidoMaterno = u.segundoApellido,
                                         Rol = u.rol,
                                         FechaNacimiento = u.fechaNacimiento,
                                         Email = u.email,
                                         Pais = u.Pais,
                                         Ciudad = u.Ciudad
                                     };
            grdUsuarios.DataBind();

        }

        protected void lnkAgregar_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            Response.Redirect("AddUsuario.aspx");
        }
    }
}