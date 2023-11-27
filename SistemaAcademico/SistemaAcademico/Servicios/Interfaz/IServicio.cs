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
        List<Horarios> TraerHorarios();
        List<Docentes> TraerDocentes();
        List<Comisiones> TraerComision();
        List<Catedra> TraerCatedras();
        List<Estudiantes> TraerEstudiante();

        List<EstadoMateria> TraerEstado();

        bool CrearCatedra(Catedra oCatedra);

        bool CrearEstudiante(Estudiantes oEstudiante);
        bool ActualizarEstudiante(Estudiantes estudiate);

        bool BorrarInscripcion(int nroCatedra);

    }
}
