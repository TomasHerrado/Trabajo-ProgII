using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademicoBackend.Entidades
{
    public class InscripcionMateria
    {
        public int Id_inscripcion { get; set; }

        public Estudiantes Estudiante { get; set; }
        public DateTime Fecha { get; set; }
        public EstadoMateria EstadoMateria { get; set; }

        public Catedra Catedras { get; set; }

        public InscripcionMateria(Estudiantes estudiante, DateTime fecha, EstadoMateria estado, Catedra catedra)
        {
            Estudiante = estudiante;
            Fecha = fecha;
            EstadoMateria = estado;
            Catedras = catedra;
        }
        public InscripcionMateria()
        {
            
        }
        
    }
}
