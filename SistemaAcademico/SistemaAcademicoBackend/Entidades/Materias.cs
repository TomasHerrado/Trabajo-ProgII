using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademicoBackend.Entidades
{
    public class Materias
    {
        private int idMateria;
        private string nombreMateria;
        private Carrera id_carrera;

        public int IdMateria
        {
            get { return idMateria; }
            set { idMateria = value;}
        }
        public string NombreMateria
        {
            get { return nombreMateria; }
            set { nombreMateria = value; }
        }
        public Carrera IdCarrera
        {
            get { return id_carrera; }
            set { id_carrera = value;}
        }
        public Materias()
        {
            idMateria = 0;
            nombreMateria = string.Empty;
            id_carrera = new Carrera();
        }
        public Materias(int id_materia, string nombre, Carrera id_carrera)
        {
            IdMateria = id_materia;
            NombreMateria = nombre;
            IdCarrera = id_carrera;
        }
    }
}
