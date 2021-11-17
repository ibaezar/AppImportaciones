using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppImportaciones.Models;

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
                    Idproducto = int.Parse(id),
                    NombreProducto = nombre,
                    Valor = float.Parse(valor),
                    Stock = int.Parse(stock),
                    CodigoVendedor = int.Parse(idVendedor)
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

        //Precargar datos
        public static void cargar()
        {
            if (listaProducto.Count < 1)
            {
                addProducto("1", "Manzanas", "50", "10000", "4");
                addProducto("2", "Naranjas", "60", "12000", "4");
                addProducto("3", "Platanos", "100", "18000", "4");
                addProducto("4", "Duraznos", "80", "5000", "4");
                addProducto("5", "Uvas", "100", "130000", "4");
            }
        }
    }
}