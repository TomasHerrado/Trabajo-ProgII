using AutoMapper;
using SistemaAcademicoBackend.Datos.Implementacion;
using SistemaAcademicoBackend.Datos.Interfaz;
using SistemaAcademicoBackend.Entidades;
using SistemaAcademicoBackend.EntidadesDto;
using SistemaAcademicoBackend.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademicoBackend.Servicios.Implementacion
{
    public class Servicio : IServicio
    {
        
        private IInscripcionMateriaDao dao;
        private readonly IMapper _mapper;

        public Servicio()
        {
            dao = new InscripcionMateriaDao(_mapper);
            
        }
        public bool ActualizarCatedra(int nro,CatedraDTO catedra)
        {
            return dao.ActualizarCatedra(nro,catedra);
        }

        public bool BorrarInscripcion(int nroCatedra)
        {
            return dao.Borrar(nroCatedra);
        }

        public bool CrearEstudiante(Estudiantes oEstudiante)
        {
            return dao.Crear(oEstudiante);
        }

        public bool CrearCatedra(CatedraDTO oCatedra)
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

        public bool ActualizarEstudiante(int nro, Estudiantes estudiante)
        {
            return dao.ActualizarEstudiante(nro, estudiante);
        }

        public bool BorrarEstudiante(int nroEstudiante)
        {
            return dao.BorrarEstudiante(nroEstudiante);
        }

        
    }
}
