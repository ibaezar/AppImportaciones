using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppImportaciones.Controllers
{
    public class ProductoController
    {
        private static List<Producto> listaProducto = new List<Producto>();

        public static string addProducto(string id, string nombre, string valor, string stock, string idVendedor)
        {
            try
            {
                Producto producto = new Producto() 
                {
                    idProducto = int.Parse(id),
                    nombreProducto = nombre,
                    valor = float.Parse(valor),
                    stock = int.Parse(stock)
                    //codigoVendedor = int.Parse(idVendedor)
                };
                
                listaProducto.Add(producto);
                return "Producto agregado correctamente";
            }
            catch (Exception e)
            {

                return "Error: "+e;
            }
        }

        public  static List<Producto> GetProductos()
        {
            return listaProducto;
        }
    }
}