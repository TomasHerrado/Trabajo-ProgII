using SistemaAcademicoBackend.Entidades;
using SistemaAcademicoBackend.EntidadesDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademicoBackend.Servicios.Interfaz
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

        bool CrearCatedra(CatedraDTO oCatedra);

        bool CrearEstudiante(Estudiantes oEstudiante);

        bool ActualizarEstudiante(int nro, Estudiantes estudiante);
        bool BorrarEstudiante(int nroEstudiante);
        bool ActualizarCatedra(int nro,CatedraDTO catedra);
       

        bool BorrarInscripcion(int nroCatedra);

    }
}
