using SistemaAcademicoBackend.Entidades;
using SistemaAcademicoBackend.EntidadesDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademicoBackend.Datos.Interfaz
{
    public interface IInscripcionMateriaDao
    {
        List<Catedra> ObtenerCatedras();
        List<Estudiantes> ObtenerEstudiante();

        List<EstadoMateria> ObtenerEstado();

        List<Horarios> ObtenerHorario();
        List<Docentes> ObtenerDocente();
        List<Comisiones> ObtenerComision();

        bool CrearCatedra(CatedraDTO catedra);
        
        List<Materias> ObtenerMaterias();
        bool Crear(Estudiantes oEstudiante);
        bool ActualizarCatedra(int nro, CatedraDTO catedra);
        bool Borrar(int nroCatedra);
        bool ActualizarEstudiante(int nro, Estudiantes estudiante);
        bool BorrarEstudiante(int nroEstudiante);
    }
}
