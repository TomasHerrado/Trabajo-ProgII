using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Entidades
{
    public class Comisiones
    {
        private int idComision;
        private string descripcionComision;

        public int IdComision
        {
            get { return idComision; }
            set { idComision = value; }
        }

        public string DescripcionComision
        {
            get { return descripcionComision; }
            set { descripcionComision = value; }
        }

        public Comisiones(int id_comision, string descripcion)
        {   
            
            IdComision = id_comision;
            DescripcionComision = descripcion;
        }
        public Comisiones()
        {
            idComision = 0;
            descripcionComision = "";
        }
    }
}
