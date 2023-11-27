using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Entidades
{
    public class Calificaciones
    {
        private int id_calificacion;
        private int nota;
        private TipoNotas id_tipo_nota;
        private InscripcionMateria id_descripcion;
        private DateTime fecha;

        public Calificaciones(int id_calificacion, int nota, TipoNotas id_tipo_nota, InscripcionMateria id_descripcion, DateTime fecha)
        {
            IdCalificacion = id_calificacion;
            Nota = nota;
            IdTipoNota = id_tipo_nota;
            IdDescripcion = id_descripcion;
            Fecha = fecha;
        }
        public Calificaciones()
        {
            id_calificacion = 0;
            Nota = 0;
            IdTipoNota = new TipoNotas();
            IdDescripcion = new InscripcionMateria();
            Fecha = DateTime.Today;
        }
        public int IdCalificacion
        {
            get { return id_calificacion; }
            set { id_calificacion = value;}
        }
        public int Nota
        {
            get { return nota; }
            set { nota = value; }
        }
        public TipoNotas IdTipoNota
        {
            get { return id_tipo_nota; }
            set { id_tipo_nota = value; }
        }
        public InscripcionMateria IdDescripcion
        {
            get { return id_descripcion; }
            set { id_descripcion = value;}
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }


    }
}
