using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Entidades
{
    public class TipoNotas
    {
        public int Id_Tipo_Nota { get; set; }
        public string Descripcion { get; set; }

        public TipoNotas()
        {
            Id_Tipo_Nota = 0;
            Descripcion = string.Empty;
        }
        public TipoNotas(int id_tipo_nota, string descripcion)
        {
            Id_Tipo_Nota = id_tipo_nota;
            Descripcion = descripcion;
        }
    }
}
