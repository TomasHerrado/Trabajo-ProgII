using AutoMapper;
using SistemaAcademicoBackend.Entidades;
using SistemaAcademicoBackend.EntidadesDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademicoBackend.Mapping
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Catedra, CatedraDTO>()
            .ForMember(dest => dest.HorarioDTO, opt => opt.MapFrom(src => src.Horario))
            .ForMember(dest => dest.MateriaDTO, opt => opt.MapFrom(src => src.Materia))
            .ForMember(dest => dest.DocenteDTO, opt => opt.MapFrom(src => src.Docente))
            .ForMember(dest => dest.ComisionDTO, opt => opt.MapFrom(src => src.Comision))
            .ReverseMap();
            CreateMap<Comisiones, ComisionDTO>().ReverseMap();
            CreateMap<Horarios, HorarioDTO>().ReverseMap();
            CreateMap<Materias, MateriasDTO>().ReverseMap();
            CreateMap<Docentes, DocenteDTO>().ReverseMap();
            CreateMap<InscripcionMateria,InscripcionMateriaDTO>()
            .ForMember(dest => dest.EstudiantesDTO, opt => opt.MapFrom(src => src.Estudiante))
            .ForMember(dest => dest.EstadoMateriaDTO, opt => opt.MapFrom(src => src.EstadoMateria))
            .ReverseMap();
            CreateMap<Estudiantes,EstudiantesDTO>().ReverseMap();
            CreateMap<EstadoMateria, EstadoMateriaDTO>().ReverseMap();
            
        }
    }
}
