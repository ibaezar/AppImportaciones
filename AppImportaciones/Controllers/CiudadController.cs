using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppImportaciones.Models;

namespace AppImportaciones.Controllers
{
    public class CiudadController
    {
        private static List<Ciudad> listaCiudad = new List<Ciudad>();
        private static List<Ciudad> ciudadPorPais = new List<Ciudad>();

        //Agregar Ciudad
        public static string addCiudad(string id, string nombre, string idPais)
        {
            try
            {
                //Buscar pais antes de crear ciudad
                Pais pais = PaisController.findById(idPais);

                //Agregar ciudad
                Ciudad ciudad = new Ciudad()
                {
                    IdCiudad = int.Parse(id),
                    NombreCiudad = nombre,
                    IdPais = pais.Idpais
                };

                listaCiudad.Add(ciudad);

                return "Ciudad agregada correctamente";
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;               
            }
        }

        //Listar Ciudades
        public static List<Ciudad> getListado(string idPais)
        {
            foreach (Ciudad ciudad in listaCiudad)
            {
                if (ciudad.IdPais.Equals(int.Parse(idPais)))
                {
                    ciudadPorPais.Add(ciudad);
                }
            }
            return ciudadPorPais;
        }

        //Precargar listado
        public static void cargar()
        {
            if (ciudadPorPais.Count < 1 && listaCiudad.Count < 1)
            {
                addCiudad("1", "Santiago", "1");
                addCiudad("2", "Concepción", "1");
                addCiudad("3", "Viña del mar", "1");
                addCiudad("4", "Valparaiso", "1");
                addCiudad("5", "Iquique", "1");

                addCiudad("6", "Buenos Aires", "2");
                addCiudad("7", "Córdoba", "2");
                addCiudad("8", "Rosario", "2");
                addCiudad("9", "Mar de PLata", "2");
                addCiudad("10", "Salta", "2");

                addCiudad("11", "Sao Paulo", "3");
                addCiudad("12", "Rio de Janeiro", "3");
                addCiudad("13", "Salvador", "3");
                addCiudad("14", "Brasilia", "3");
                addCiudad("15", "Fortalesa", "3");

                addCiudad("16", "Lima", "4");
                addCiudad("17", "Cusco", "4");
                addCiudad("18", "Arequipa", "4");
                addCiudad("19", "Trujillo", "4");
                addCiudad("20", "Tacna", "4");

                addCiudad("21", "Bogotá", "5");
                addCiudad("22", "Medellín", "5");
                addCiudad("23", "Cali", "5");
                addCiudad("24", "Barranquilla", "5");
                addCiudad("25", "Bucaramanga", "5");

                addCiudad("26", "La Habana", "6");
                addCiudad("27", "Santiago de Cuba", "6");
                addCiudad("28", "Trinidad", "6");
                addCiudad("29", "Santa Clara", "6");
                addCiudad("30", "Bayamo", "6");
            }
        }

    }
}