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
        private int idPais;

        public int IdPais
        {
            get { return idPais; }
            set { idPais = value; }
        }



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