using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Entidades
{
    public class EstudianteCarrera
    {
        public int Id_estudiante_carrera { get; set; }
        public Estudiantes Id_estudiante { get; set; }
        public Carrera Id_carrera { set; get; }

        public EstudianteCarrera(int id_estudiante_carrera, Estudiantes id_estudiante, Carrera id_carrera)
        {
            Id_estudiante_carrera = id_estudiante_carrera;
            Id_estudiante = id_estudiante;
            Id_carrera = id_carrera;
        }
        public EstudianteCarrera()
        {
            Id_estudiante_carrera = 0;
            Id_estudiante = new Estudiantes();
            Id_carrera = new Carrera();
        }
    }
}
