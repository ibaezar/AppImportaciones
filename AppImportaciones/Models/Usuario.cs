using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppImportaciones.Models
{
    public class Usuario
    {
        private int idUsuario;
        private string nombre;
        private string primerApellido;
        private string segundoApellido;
        private string fechaNacimiento;
        private string rol;
        private string email;
        private int numCelular;
        private string pais;
        private string ciudad;
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }


        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }


        public int NumCelular
        {
            get { return numCelular; }
            set { numCelular = value; }
        }


        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public string Rol
        {
            get { return rol; }
            set { rol = value; }
        }


        public string FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }


        public string SegundoApellido
        {
            get { return segundoApellido; }
            set { segundoApellido = value; }
        }


        public string PrimerApellido
        {
            get { return primerApellido; }
            set { primerApellido = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
    }
}