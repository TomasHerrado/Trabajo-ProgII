using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Entidades
{
    public class Carrera
    {
        public int Id_Carrera { get; set; }
        public string Nombre_carrera { get; set; }
        public string Descripcion { get; set; }
        public string Duracion { get; set; }
        public string Titulo_otorgado { get; set; }

        public Carrera(int id_carrera, string nombre_carrera, string descripcion, string duracion, string titulo_otorgado)
        {
            Id_Carrera = id_carrera;
            Nombre_carrera = nombre_carrera;
            Descripcion = descripcion;
            Duracion = duracion;
            Titulo_otorgado = titulo_otorgado;
        }
        public Carrera()
        {
            Id_Carrera = 0;
            Nombre_carrera = "";
            Descripcion = "";
            Duracion = "";
            Titulo_otorgado = "";
        }
    }
}
