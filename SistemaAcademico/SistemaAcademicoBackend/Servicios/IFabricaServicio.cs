using SistemaAcademicoBackend.Servicios.Implementacion;
using SistemaAcademicoBackend.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademicoBackend.Servicios
{
    public class IFabricaServicio : FabricaServicio
    {
        public override IServicio CrearServicio()
        {
            return new Servicios.Implementacion.Servicio();
        }
    }
}
