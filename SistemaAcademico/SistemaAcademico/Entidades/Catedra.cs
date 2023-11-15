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
        public Horarios Id_horario { get; set; }
        public Materias Id_materia { get; set; }
        public Docentes Id_docente { get; set; }
        public Comisiones Id_comision { get; set; }
        public string Año { get; set; }
        public string Cuatrimestre { get; set; }

        public Catedra()
        {
            Id_catedra = 0;
            Descripcion = string.Empty;
            Id_horario = new Horarios();
            Id_materia = new Materias();
            Id_docente = new Docentes();
            Id_comision = new Comisiones();
            Año = string.Empty;
            Cuatrimestre = string.Empty;
        }
        public Catedra(int id_catedra, string descripcion, Horarios id_horario, Materias id_materia, Docentes id_docente, Comisiones id_comision, string año, string cuatrimestre)
        {
            Id_catedra = id_catedra;
            Descripcion = descripcion;
            Id_horario = id_horario;
            Id_materia = id_materia;
            Id_docente = id_docente;
            Id_comision = id_comision;
            Año = año;
            Cuatrimestre = cuatrimestre;
        }
    }
}
