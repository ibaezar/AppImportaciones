using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Librerias para encriptación MD5
using System.Security.Cryptography;
using System.Text;

namespace AppImportaciones.Controllers
{
    public class UsuarioController
    {
        private static DB_AppImportacionesEntities db = new DB_AppImportacionesEntities();
        private static List<string> rol = new List<string>();
        private static List<Usuario> UserByRol = new List<Usuario>();
        private static List<Usuario> listaUsuario = new List<Usuario>();

        public static string addUsuario(string nombre, string apellido1, string apellido2, string fecha, string rol, string email, string num, string idPais, string idCiudad, string password)
        {
            try
            {
                //Rellenar objeto Usuario.
                Usuario usuario = new Usuario() 
                {
                    nombre = nombre,
                    primerApellido = apellido1,
                    segundoApellido = apellido2,
                    fechaNacimiento = fecha,
                    rol = rol,
                    email = email,
                    numCelular = int.Parse(num),
                    fk_pais = int.Parse(idPais),
                    fk_ciudad = int.Parse(idCiudad),
                    password = GetMD5(password)
                };

                db.Usuario.Add(usuario);
                db.SaveChanges();

                return "Usuario creado correctamente";
            }
            catch (Exception e)
            {
                return "Error "+e;
            }
        }

        public static List<Usuario> getUsers()
        {
            listaUsuario.Clear();
            foreach (Usuario usr in db.Usuario)
            {
                listaUsuario.Add(usr);
            }
            return listaUsuario;
        }

        public static List<Usuario> getUserByRol(string rol)
        {
            UserByRol.Clear();
            listaUsuario.Clear();
            foreach (Usuario usr in db.Usuario)
            {
                listaUsuario.Add(usr);
            }

            foreach (Usuario usuario in listaUsuario)
            {
                if (usuario.rol.Equals(rol))
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

        //Encriptar password
        public static string GetMD5(string contrasena)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding codificar = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(codificar.GetBytes(contrasena));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}