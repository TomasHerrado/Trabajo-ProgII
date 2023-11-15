using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Entidades
{
    public class Comisiones
    {
        private int id_comisiones;
        private string descripcion;

        public int IdComisiones
        {
            get { return id_comisiones; }
            set { id_comisiones = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public Comisiones(int id_comisiones, string descripcion)
        {
            
            IdComisiones = id_comisiones;
            Descripcion = descripcion;
        }
        public Comisiones()
        {
            id_comisiones = 0;
            descripcion = "";
        }
    }
}
