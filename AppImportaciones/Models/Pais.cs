using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppImportaciones.Models
{
    public class Pais
    {
        private int idPais;
        private string nombrePais;

        public string NombrePais
        {
            get { return nombrePais; }
            set { nombrePais = value; }
        }


        public int Idpais
        {
            get { return idPais; }
            set { idPais = value; }
        }
    }
}