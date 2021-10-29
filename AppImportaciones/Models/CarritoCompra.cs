using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppImportaciones.Models
{
    public class CarritoCompra
    {
        private int idProducto;
        private string nombreProducto;
        private int cantidad;
        private float valor;
        private int codigoComprador;

        public int CodigoComprador
        {
            get { return codigoComprador; }
            set { codigoComprador = value; }
        }


        public float Valor
        {
            get { return valor; }
            set { valor = value; }
        }



        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }


        public string NombreProducto
        {
            get { return nombreProducto; }
            set { nombreProducto = value; }
        }


        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }
    }
}