using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppImportaciones.Controllers
{
    public class ProductoController
    {
        private static DB_AppImportacionesEntities db = new DB_AppImportacionesEntities();
        private static List<Producto> listaProducto = new List<Producto>();

        public static string addProducto(string nombre, string valor, string stock)
        {
            try
            {
                Producto producto = new Producto() 
                {
                    nombreProducto = nombre,
                    valor = float.Parse(valor),
                    stock = int.Parse(stock)
                    //codigoVendedor = int.Parse(idVendedor)
                };

                db.Producto.Add(producto);
                db.SaveChanges();

                return "Producto agregado correctamente";
            }
            catch (Exception e)
            {

                return "Error: "+e;
            }
        }

        public  static List<Producto> GetProductos()
        {
            listaProducto.Clear();

            foreach (Producto producto in db.Producto)
            {
                listaProducto.Add(producto);
            }

            return listaProducto;
        }
    }
}