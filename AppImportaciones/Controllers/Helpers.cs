using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppImportaciones.Controllers
{
    public class Helpers
    {
        public static void precargarDatos()
        {
            PaisController.cargar();
            CiudadController.cargar();
            UsuarioController.cargar();
            UsuarioController.cargarRol();
            ProductoController.cargar();
        }

    }
}