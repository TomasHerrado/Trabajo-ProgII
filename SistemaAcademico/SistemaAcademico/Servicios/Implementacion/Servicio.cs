using SistemaAcademico.Datos.Implementacion;
using SistemaAcademico.Datos.Interfaz;
using SistemaAcademico.Entidades;
using SistemaAcademico.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Servicios.Implementacion
{
    public class Servicio : IServicio
    {
        private IInscripcionMateriaDao dao;

        public Servicio()
        {
            dao = new InscripcionMateriaDao();
        }
        public bool ActualizarEstudiante(Estudiantes estudiate)
        {
            throw new NotImplementedException();
        }

        public bool BorrarInscripcion(int nroCatedra)
        {
            return dao.Borrar(nroCatedra);
        }

        public bool CrearEstudiante(Estudiantes oEstudiante)
        {
            return dao.Crear(oEstudiante);
        }

        public bool CrearCatedra(Catedra oCatedra)
        {
            return dao.CrearCatedra(oCatedra);
        }

        public List<Catedra> TraerCatedras()
        {
            return dao.ObtenerCatedras();
        }

        public List<Comisiones> TraerComision()
        {
            return dao.ObtenerComision();
        }

        public List<Docentes> TraerDocentes()
        {
            return dao.ObtenerDocente();
        }

        public List<EstadoMateria> TraerEstado()
        {
            return dao.ObtenerEstado();
        }

        public List<Estudiantes> TraerEstudiante()
        {
            return dao.ObtenerEstudiante();
        }

        public List<Horarios> TraerHorarios()
        {
            return dao.ObtenerHorario();
        }

        public List<Materias> TraerMaterias()
        {
            return dao.ObtenerMaterias();
        }
    }
}
