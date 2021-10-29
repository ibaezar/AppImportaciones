using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppImportaciones.Models
{
    public class Pedido
    {
        private int idPedido;
        private int numeroPedido;
        private int fechaPedido;
        private int fechaEnvio;
        private bool estado;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }


        public int FechaEnvio
        {
            get { return fechaEnvio; }
            set { fechaEnvio = value; }
        }


        public int FechaPedido
        {
            get { return fechaPedido; }
            set { fechaPedido = value; }
        }


        public int NumeroPedido
        {
            get { return numeroPedido; }
            set { numeroPedido = value; }
        }


        public int IdPedido
        {
            get { return idPedido; }
            set { idPedido = value; }
        }
    }
}