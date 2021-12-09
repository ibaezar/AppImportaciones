using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppImportaciones.Models;

namespace AppImportaciones.Controllers
{
    public class UsuarioController
    {
        private static List<string> rol = new List<string>();
        private static List<Usuario> UserByRol = new List<Usuario>();
        private static List<Usuario> listaUsuario = new List<Usuario>();

        public static string addUsuario(string id, string nombre, string apellido1, string apellido2, string fecha, string rol, string email, string num, string pais, string ciudad, string password)
        {
            try
            {
                Usuario usuario = new Usuario() 
                {
                    IdUsuario = int.Parse(id),
                    Nombre = nombre,
                    PrimerApellido = apellido1,
                    SegundoApellido = apellido2,
                    FechaNacimiento = fecha,
                    Rol = rol,
                    Email = email,
                    NumCelular = int.Parse(num),
                    Pais = pais,
                    Ciudad = ciudad,
                    Password = password
                };

                listaUsuario.Add(usuario);
                return "Usuario creado correctamente";
            }
            catch (Exception e)
            {
                return "Error "+e;
            }
        }

        public static List<Usuario> getUsers()
        {
            return listaUsuario;
        }

        public static List<Usuario> getUserByRol(string rol)
        {
            foreach (Usuario usuario in listaUsuario)
            {
                if (usuario.Rol.Equals(rol))
                {
                    UserByRol.Add(usuario);
                }
            }
            return UserByRol;
        }

        public static List<string> getRol()
        {
            return rol;
        }

        //Cargar roles
        public static void cargarRol()
        {
            if(rol.Count < 1)
            {
                rol.Add("Administrador");
                rol.Add("Vendedor");
                rol.Add("Comprador");
            }
        }

        //Precarda de datos
        public static void cargar()
        {
            if (listaUsuario.Count < 1)
            {
                addUsuario("1", "Izhar", "Baeza", "Reyes", "13-01-1994", "Administrador", "ibaezar@outlook.com", "994905228", "Chile", "Santiago", "123456");
                addUsuario("2", "Geremy", "Navarrete", "Suazo", "20-02-1996", "Administrador", "gnavarrete@gmail.com", "994523587", "Chile", "Santiago", "123456");
                addUsuario("3", "Yuber", "Gallardo", "Reyes", "26-06-1990", "Administrador", "ygallardo@gmail.com", "984624659", "Chile", "Santiago", "123456");
                addUsuario("4", "Elena", "Nito", "Delgado", "30-08-1998", "Vendedor", "enito@gmail.com", "975132695", "Argentina", "Buenos Aires", "123456");
                addUsuario("5", "Felipe", "Kast", "Izquierdo", "25-03-1970", "Comprador", "fkast@gmail.com", "951235467", "Cuba", "La Habana", "123456");
            }
        }
    }
}