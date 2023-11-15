using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Entidades
{
    public class InscripcionMateria
    {
        public int Id_inscripcion { get; set; }
        public List<Catedra> lCatedra { get; set; }
        public List<Estudiantes> lEstudiante { get; set; }
        public DateTime Fecha { get; set; }
        public List<EstadoMateria> lEstadoMateria { get; set; }

        public InscripcionMateria()
        {
            lCatedra= new List<Catedra>();
            lEstadoMateria=new List<EstadoMateria>();
            lEstudiante=new List<Estudiantes>();
        }
        public void AgregarDetalle(Catedra catedra,Estudiantes estudiante,EstadoMateria estado)
        {
            lEstudiante.Add(estudiante);
            lEstadoMateria.Add(estado);
            lCatedra.Add(catedra);
        }
        public void QuitarDetalle(int posicion)
        {
            lCatedra.RemoveAt(posicion);
            lEstadoMateria.RemoveAt(posicion);
            lEstudiante.RemoveAt(posicion);
        }
    }
}
