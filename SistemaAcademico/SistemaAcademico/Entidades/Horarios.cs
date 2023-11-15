using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Entidades
{
    public class Horarios
    {
        private int id_horarios;
        private string dia_semana;
        private string hora_inicio;
        private string hora_fin;
        private int aula;

        public int IdHorarios
        {
            get { return id_horarios; }
            set { id_horarios = value; }
        }
        public string DiaSemana
        {
            get { return dia_semana; }
            set { dia_semana = value; }
        }
        public string HoraInicio
        {
            get { return hora_inicio; }
            set { hora_inicio = value;}
        }
        public string HoraFin
        {
            get { return hora_fin; }
            set { hora_fin = value; }
        }
        public int Aula
        {
            get { return aula; }
            set { aula = value; }
        }
        public Horarios()
        {
            id_horarios = 0;
            dia_semana = "";
            hora_inicio = "";
            hora_fin = "";
            aula = 0;
        }
        public Horarios(int id_horarios, string dia_semana, string hora_inicio, string hora_fin, int aula)
        {
            IdHorarios = id_horarios;
            DiaSemana = dia_semana;
            HoraInicio = hora_inicio;
            HoraFin = hora_fin;
            Aula = aula;
        }



    }
}
