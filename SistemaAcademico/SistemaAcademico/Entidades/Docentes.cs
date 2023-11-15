using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Entidades
{
    public class Docentes
    {
        private int id_docente;
        private string nombre;
        private string apellido;
        private DateTime fecha_nac;
        private int dni;
        private string direccion;
        private int telefono;
        private string email;

        public int Id_Docente
        {
            get { return id_docente; }
            set { id_docente = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public DateTime Fecha_Nac
        {
            get { return fecha_nac; }
            set { fecha_nac = value; }
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public Docentes(int id_docente, string nombre, string apellido, DateTime fecha_nac, int dni, string direccion, int telefono, string email)
        {
            this.id_docente = id_docente;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecha_nac = fecha_nac;
            this.dni = dni;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
        }
        public Docentes()
        {
            id_docente = 0;
            nombre = "";
            apellido = "";
            fecha_nac = DateTime.Today;
            dni = 0;
            direccion = "";
            telefono = 0;
            email = "";
        }

    }
}
