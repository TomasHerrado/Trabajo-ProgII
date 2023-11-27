using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Entidades
{
    public class ExamenFinal
    {
        public int Id_examen_final { get; set; }
        public string Turno { get; set; }
        public DateTime Fecha { get; set; }
        public Docentes Id_docente { get; set; }
        public Materias Id_materia { get; set; }

        public ExamenFinal(int id_examen_final, string turno, DateTime fecha, Docentes id_docente, Materias id_materia)
        {
            Id_examen_final = id_examen_final;
            Turno = turno;
            Fecha = fecha;
            Id_docente = id_docente;
            Id_materia = id_materia;
        }
        public ExamenFinal()
        {
            Id_examen_final = 0;
            Turno = "";
            Fecha = DateTime.Today;
            Id_docente = new Docentes();
            Id_materia = new Materias();
        }
    }
}
