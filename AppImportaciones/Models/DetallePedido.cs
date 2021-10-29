using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppImportaciones.Models
{
    public class DetallePedido
    {
        private int idDetallePedido;
        private int idPedido;
        private int idProducto;
        private int cantidad;
        private float valorUnidad;
        private float subTotal;

        public float SubTotal
        {
            get { return subTotal; }
            set { subTotal = value; }
        }


        public float ValorUnidad
        {
            get { return valorUnidad; }
            set { valorUnidad = value; }
        }


        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }


        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }


        public int IdPedido
        {
            get { return idPedido; }
            set { idPedido = value; }
        }


        public int IdDetallePedido
        {
            get { return idDetallePedido; }
            set { idDetallePedido = value; }
        }
    }
}