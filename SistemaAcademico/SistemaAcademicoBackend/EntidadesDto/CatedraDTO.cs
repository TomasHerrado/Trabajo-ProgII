using SistemaAcademicoBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademicoBackend.EntidadesDto
{
    public class CatedraDTO
    {
        public string Descripcion { get; set; }
        public HorarioDTO HorarioDTO { get; set; }
        public MateriasDTO  MateriaDTO { get; set; }
        public DocenteDTO DocenteDTO { get; set; }
        public ComisionDTO ComisionDTO { get; set; }
        public string Año { get; set; }
        public string Cuatrimestre { get; set; }
        public List<InscripcionMateriaDTO> lInscripcionDTO { get; set; }
        public CatedraDTO()
        {
            lInscripcionDTO=new List<InscripcionMateriaDTO>();
            
        }
        public void AgregarDetalle(InscripcionMateriaDTO matDTO)
        {
            lInscripcionDTO.Add(matDTO);
        }

    }
}
