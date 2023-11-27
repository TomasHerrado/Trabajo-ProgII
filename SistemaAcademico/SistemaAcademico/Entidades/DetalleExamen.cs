using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Entidades
{
    public class DetalleExamen
    {
        public int id_detalle_examen{ get;set; }
        public ExamenFinal id_examen_final { get; set; }
        public Estudiantes id_estudiante { get; set; }
        public int nota { get; set; }

        public DetalleExamen(int id_detalle_examen, ExamenFinal id_examen_final, Estudiantes id_estudiante, int nota)
        {
            this.id_detalle_examen = id_detalle_examen;
            this.id_examen_final = id_examen_final;
            this.id_estudiante = id_estudiante;
            this.nota = nota;
        }
        public DetalleExamen()
        {
            id_detalle_examen = 0;
            id_examen_final = new ExamenFinal();
            id_estudiante = new Estudiantes();
            nota = 0;
        }

    }
}
