using SistemaAcademico.Servicios.Implementacion;
using SistemaAcademico.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Servicios
{
    public class IFabricaServicio : FabricaServicio
    {
        public override IServicio CrearServicio()
        {
            return new Servicios.Implementacion.Servicio();
        }
    }
}
