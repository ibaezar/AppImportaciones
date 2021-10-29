using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppImportaciones.Models
{
    public class Ciudad
    {
        private int idCiudad;
        private string nombreCiudad;

        public string NombreCiudad
        {
            get { return nombreCiudad; }
            set { nombreCiudad = value; }
        }


        public int IdCiudad
        {
            get { return idCiudad; }
            set { idCiudad = value; }
        }
    }
}