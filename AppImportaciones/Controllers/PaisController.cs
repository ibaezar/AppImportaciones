using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppImportaciones.Controllers
{
    public class PaisController
    {
        private static List<Pais> listaPais = new List<Pais>();
        private static DB_AppImportacionesEntities db = new DB_AppImportacionesEntities();

        //Metodo para agregar pais
        public static string addPais(string nombrePais)
        {
            try
            {
                Pais pais = new Pais()
                {
                    nombrePais = nombrePais
                };

                db.Pais.Add(pais);
                db.SaveChanges();

                return "Pais agregado correctamente";
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }
        }

        //Buscar por id
        public static Pais findById(string id)
        {
            listaPais.Clear();
            foreach (Pais pais in db.Pais)
            {
                listaPais.Add(pais);
            }

            foreach (Pais pais in listaPais)
            {
                if (pais.idPais.Equals(int.Parse(id)))
                {
                    return pais;
                }
            }
            return null;
        }


        //Metodo para listar paises
        public static List<Pais> getPais()
        {
            listaPais.Clear();
            foreach (Pais pais in db.Pais)
            {
                listaPais.Add(pais);
            }

            return listaPais;
        }
    }
}  