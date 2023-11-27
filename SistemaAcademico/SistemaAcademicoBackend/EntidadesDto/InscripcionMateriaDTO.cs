using SistemaAcademicoBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademicoBackend.EntidadesDto
{
    public class InscripcionMateriaDTO
    {
        public EstudiantesDTO EstudiantesDTO { get; set; }
        public DateTime Fecha { get; set; }
        public EstadoMateriaDTO EstadoMateriaDTO { get; set; }

        public InscripcionMateriaDTO(EstudiantesDTO estudianteDTO,DateTime fechaDTO,EstadoMateriaDTO estadoDTO) 
        {
            EstudiantesDTO= estudianteDTO;
            Fecha= fechaDTO;
            EstadoMateriaDTO= estadoDTO;
        }

        
    }
}
