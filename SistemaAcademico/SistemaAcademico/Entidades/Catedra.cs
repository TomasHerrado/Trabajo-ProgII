using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Entidades
{
    public class Catedra
    {
        public int Id_catedra { get; set; }
        public string Descripcion { get; set; }
        public Horarios Horario { get; set; }
        public Materias Materia { get; set; }
        public Docentes Docente { get; set; }
        public Comisiones Comision { get; set; }
        public string Año { get; set; }
        public string Cuatrimestre { get; set; }
        public List<InscripcionMateria> lInscripcion { get; set; }
        

        public Catedra()
        {
            //Id_catedra = 0;
            //Descripcion = string.Empty;
            //Id_horario = new Horarios();
            //Id_materia = new Materias();
            //Id_docente = new Docentes();
            //Id_comision = new Comisiones();
            //Año = string.Empty;
            //Cuatrimestre = string.Empty;
            lInscripcion= new List<InscripcionMateria>();
        }

        public Catedra(int id_catedra, string descripcion, Horarios id_horario, Materias id_materia, Docentes id_docente, Comisiones id_comision, string año, string cuatrimestre)
        {
            Id_catedra = id_catedra;
            Descripcion = descripcion;
            Horario = id_horario;
            Materia = id_materia;
            Docente = id_docente;
            Comision = id_comision;
            Año = año;
            Cuatrimestre = cuatrimestre;
        }


        public void AgregarDetalle(InscripcionMateria mat)
        {
            lInscripcion.Add(mat);
        }

        //Preguntar 
        public void QuitarDetalle(int posicion)
        {
            lInscripcion.RemoveAt(posicion);
        }
    }
}
