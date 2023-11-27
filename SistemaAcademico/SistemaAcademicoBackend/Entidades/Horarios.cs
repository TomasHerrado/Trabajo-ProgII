using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademicoBackend.Entidades
{
    public class Horarios
    {
        private int idHorarios;
        private string diaSemana;
        private string hora_inicio;
        private string hora_fin;
        private int aula;

        public int IdHorarios
        {
            get { return idHorarios; }
            set { idHorarios = value; }
        }
        public string DiaSemana
        {
            get { return diaSemana; }
            set { diaSemana = value; }
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
            idHorarios = 0;
            diaSemana = "";
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
