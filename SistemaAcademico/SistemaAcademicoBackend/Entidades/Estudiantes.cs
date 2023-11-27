using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademicoBackend.Entidades
{
    public class Estudiantes
    {
        private int id_estuidante;
        private string nombre;
        private string apellido;
        private DateTime fecha_nac;
        private int dni;
        private string direccion;
        private int telefono;
        private string email;
        private string estado_civil;
        private string sit_habitacional;
        private string sit_laboral;


        public int Id_Estudiante
        {
            get { return id_estuidante;}
            set { id_estuidante = value;}
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
            get { return fecha_nac;}
            set { fecha_nac = value;}
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Direccion
        {
            get { return direccion;}
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
        public string EstadoCivil
        {
            get { return estado_civil; }
            set { estado_civil = value; }
        }
        public string SitHabitacional
        {
            get { return sit_habitacional; }
            set { sit_habitacional = value; }
        }
        public string SitLaboral
        {
            get { return sit_laboral; }
            set { sit_laboral = value; }
        }

        public Estudiantes( int id_estuidante, string nombre, string apellido, DateTime fecha_nac, int dni, string direccion, int telefono, string email,string estado_civil,string sit_habitacional,string sit_laboral)
        {
            Id_Estudiante = id_estuidante;
            Nombre = nombre;
            Apellido = apellido;
            Fecha_Nac = fecha_nac;
            Dni= dni;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            EstadoCivil = estado_civil;
            SitHabitacional = sit_habitacional;
            SitLaboral = sit_laboral;
        }
        public Estudiantes()
        {
            id_estuidante = 0;
            Nombre = "";
            Apellido = "";
            Fecha_Nac = DateTime.Today;
            Dni = 0;
            Direccion = "";
            Telefono = 0;
            Email = "";
            SitHabitacional = "";
            sit_laboral = "";
            
        }
        
        
        

    }

}
