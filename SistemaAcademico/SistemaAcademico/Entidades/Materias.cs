using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Entidades
{
    public class Materias
    {
        private int id_materia;
        private string nombre;
        private Carrera id_carrera;

        public int IdMateria
        {
            get { return id_materia; }
            set { id_materia = value;}
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public Carrera IdCarrera
        {
            get { return id_carrera; }
            set { id_carrera = value;}
        }
        public Materias()
        {
            id_materia = 0;
            nombre = string.Empty;
            id_carrera = new Carrera();
        }
        public Materias(int id_materia, string nombre, Carrera id_carrera)
        {
            IdMateria = id_materia;
            Nombre = nombre;
            IdCarrera = id_carrera;
        }
    }
}
