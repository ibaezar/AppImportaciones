using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppImportaciones.Models;

namespace AppImportaciones.Controllers
{
    public class PaisController
    {
        private static List<Pais> listaPais = new List<Pais>();

        //Metodo para agregar pais
        public static string addPais(string idPais, string nombrePais)
        {
            try
            {
                Pais pais = new Pais()
                {
                    Idpais = int.Parse(idPais),
                    NombrePais = nombrePais
                };

                listaPais.Add(pais);

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
            foreach (Pais pais in listaPais)
            {
                if (pais.Idpais.Equals(int.Parse(id)))
                {
                    return pais;
                }
            }
            return null;
        }


        //Metodo para listar paises
        public static List<Pais> getPais()
        {
            return listaPais;
        }

        //Precargar listado
        public static void cargar()
        {
            if(listaPais.Count < 1)
            {
                addPais("1", "Chile");
                addPais("2", "Argentina");
                addPais("3", "Brasil");
                addPais("4", "Perú");
                addPais("5", "Colombia");
                addPais("6", "Cuba");
            }
        }
    }
}  