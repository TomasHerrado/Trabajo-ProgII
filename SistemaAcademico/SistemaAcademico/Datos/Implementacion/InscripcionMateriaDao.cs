using SistemaAcademico.Datos.Interfaz;
using SistemaAcademico.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Datos.Implementacion
{
    public class InscripcionMateriaDao : IInscripcionMateriaDao
    {
        public bool Actualizar(Estudiantes estudiate)
        {
            throw new NotImplementedException();
            //bool resultado = true;
            //SqlTransaction t = null;
            //SqlConnection conexion = new HelperDao().ObtenerInstancia().ObtenerConexion();

            //try
            //{
            //    conexion.Open();
            //    t = conexion.BeginTransaction();
            //    SqlCommand comando = new SqlCommand();
            //    comando.Connection = conexion;
            //    comando.Transaction = t;
            //    comando.CommandType = CommandType.StoredProcedure;
            //    comando.CommandText = "SP_ACTUALIZAR_INSCRIPCION";
            //    SqlCommand comando2 = new SqlCommand();
            //    comando2.Connection = conexion;
            //    comando2.Transaction = t;
            //    comando2.CommandType = CommandType.StoredProcedure;
            //    comando2.CommandText = "SP_BORRAR_CATEDRA";
            //    comando.Parameters.AddWithValue("", );
            //    comando.Parameters.AddWithValue("", );
            //    comando.Parameters.AddWithValue("", );
            //    comando.ExecuteNonQuery();
            //    comando2.Parameters.AddWithValue("", );
            //    comando2.ExecuteNonQuery();
            //}
        }

        public bool Borrar(int nroEstudiante)
        {
            throw new NotImplementedException();
        }

        public bool Crear(Estudiantes oEstudiante)
        {
            throw new NotImplementedException();
        }

        public List<Materias> ObtenerMaterias()
        {
            throw new NotImplementedException();
        }
    }
}
