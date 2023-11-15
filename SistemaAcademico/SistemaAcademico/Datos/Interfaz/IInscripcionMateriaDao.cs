using SistemaAcademico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Datos.Interfaz
{
    public interface IInscripcionMateriaDao
    {
        List<Materias> ObtenerMaterias();
        bool Crear(Estudiantes oEstudiante);
        bool Actualizar(Estudiantes estudiate);

        bool Borrar(int nroEstudiante);
    }
}
