using SistemaAcademico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Servicios.Interfaz
{
    public interface IServicio
    {
        List<Materias> TraerMaterias();

        bool CrearEstudiante(Estudiantes oEstudiante);
        bool ActualizarEstudiante(Estudiantes estudiate);

        bool BorrarEstudiante(int nroEstudiante);

    }
}
