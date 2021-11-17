﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppImportaciones.Models
{
    public class Producto
    {
        private int idProducto;
        private string nombreProducto;
        private int stock;
        private float valor;
        private int codigoVendedor;

        public float Valor
        {
            get { return valor; }
            set { valor = value; }
        }


        public int CodigoVendedor
        {
            get { return codigoVendedor; }
            set { codigoVendedor = value; }
        }


        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }


        public string NombreProducto
        {
            get { return nombreProducto; }
            set { nombreProducto = value; }
        }


        public int Idproducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }
    }
}