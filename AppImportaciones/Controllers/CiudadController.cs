using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppImportaciones.Controllers
{
    public class CiudadController
    {
        private static DB_AppImportacionesEntities db = new DB_AppImportacionesEntities();
        private static List<Ciudad> listaCiudad = new List<Ciudad>();
        private static List<Ciudad> ciudadPorPais = new List<Ciudad>();

        //Agregar Ciudad
        public static string addCiudad(string nombre, string idPais)
        {
            try
            {
                //Buscar pais antes de crear ciudad
                Pais pais = PaisController.findById(idPais);

                //Agregar ciudad
                Ciudad ciudad = new Ciudad()
                {
                    nombreCiudad = nombre,
                    fk_pais = pais.idPais
                };

                db.Ciudad.Add(ciudad);
                db.SaveChanges();

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
            ciudadPorPais.Clear();
            listaCiudad.Clear();

            foreach (Ciudad ciudad in db.Ciudad)
            {
                listaCiudad.Add(ciudad);
            }

            foreach (Ciudad ciudad in listaCiudad)
            {
                if (ciudad.fk_pais.Equals(int.Parse(idPais)))
                {
                    ciudadPorPais.Add(ciudad);
                }
            }
            return ciudadPorPais;
        }
    }
}