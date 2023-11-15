using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Entidades
{
    public class EstadoMateria
    {
        public int id_estado_materia { get; set; }
        public string descripcion { get; set; }

        public EstadoMateria(int id_estado_materia, string descripcion)
        {
            this.id_estado_materia = id_estado_materia;
            this.descripcion = descripcion;
        }
        public EstadoMateria()
        {
            id_estado_materia = 0;
            descripcion = "";
        }
    }
}
