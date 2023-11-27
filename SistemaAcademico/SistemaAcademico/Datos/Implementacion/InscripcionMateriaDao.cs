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

        public bool Borrar(int nroCatedra)
        {
            bool aux = true;
            SqlConnection conexion = new HelperDao().ObtenerInstancia().ObtenerConexion();
            SqlTransaction transaccion = null;
            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand("SP_BORRAR_CARGA", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                //Parametro param = new Parametro("@Id_inscripcion",nroInscripcion);
                Parametro param = new Parametro("@id_catedra",nroCatedra);
                comando.Parameters.AddWithValue(param.Nombre, param.Valor);
                comando.ExecuteNonQuery();
                transaccion.Commit();
            }
            catch
            {
                if (transaccion != null)
                {
                    transaccion.Rollback();
                    aux = false;
                }
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return aux;
        }

        public bool Crear(Estudiantes oEstudiante)
        {
            bool resultado = true;
            SqlConnection conexion = new HelperDao().ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_INSERTER_ESTUDIANTE";
                comando.Parameters.AddWithValue("@nombre_estudiante", oEstudiante.Nombre);
                comando.Parameters.AddWithValue("@apellido_estudiante", oEstudiante.Apellido);
                comando.Parameters.AddWithValue("@fecha_nac", oEstudiante.Fecha_Nac);
                comando.Parameters.AddWithValue("@dni", oEstudiante.Dni);
                comando.Parameters.AddWithValue("@direccion", oEstudiante.Direccion);
                comando.Parameters.AddWithValue("@telefono", oEstudiante.Telefono);
                comando.Parameters.AddWithValue("@email", oEstudiante.Email);
                comando.Parameters.AddWithValue("@estado_civil", oEstudiante.EstadoCivil);
                comando.Parameters.AddWithValue("@situacion_hab", oEstudiante.SitHabitacional);
                comando.Parameters.AddWithValue("@situacion_lab", oEstudiante.SitLaboral);

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@id_estudiante";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parametro);

                comando.ExecuteNonQuery();


                t.Commit();


            }
            catch
            {
                if (t != null)
                {
                    t.Rollback();
                    resultado = false;
                }

            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resultado;
        }

        public bool CrearCatedra(Catedra catedra)
        {
            bool resultado = true;
            SqlConnection conexion = new HelperDao().ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_INSERTAR_CATEDRA";
                comando.Parameters.AddWithValue("@descripcion", catedra.Descripcion);
                comando.Parameters.AddWithValue("@id_horario", catedra.Horario.IdHorarios);
                comando.Parameters.AddWithValue("@id_materia", catedra.Materia.IdMateria);
                comando.Parameters.AddWithValue("@id_docente", catedra.Docente.Id_Docente);
                comando.Parameters.AddWithValue("@id_comision", catedra.Comision.IdComision);
                comando.Parameters.AddWithValue("@año", catedra.Año);
                comando.Parameters.AddWithValue("@cuatri", catedra.Cuatrimestre);

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@id_catedra";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parametro);

                comando.ExecuteNonQuery();

                SqlCommand cmdDetalle;
                foreach (InscripcionMateria dp in catedra.lInscripcion)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_INSCRIPCION_MATERIA", conexion, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@id_catedra", dp.Catedras.Id_catedra);
                    cmdDetalle.Parameters.AddWithValue("@id_estudiante", dp.Estudiante.Id_Estudiante);
                    cmdDetalle.Parameters.AddWithValue("@fecha", dp.Fecha);
                    cmdDetalle.Parameters.AddWithValue("@id_estado_materia", dp.EstadoMateria.id_estado_materia);

                    SqlParameter parametro2 = new SqlParameter();
                    parametro2.ParameterName = "@id_inscripcion";
                    parametro2.SqlDbType = SqlDbType.Int;
                    parametro2.Direction = ParameterDirection.Output;
                    cmdDetalle.Parameters.Add(parametro2);

                    cmdDetalle.ExecuteNonQuery();
                }

                t.Commit();


            }
            catch
            {
                if (t != null)
                {
                    t.Rollback();
                    resultado = false;
                }

            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resultado;
        }

        public List<Catedra> ObtenerCatedras()
        {
            List<Catedra> lCatedra = new List<Catedra>();
            DataTable tabla = new HelperDao().ObtenerInstancia().Consultar("SP_CONSULTAR_CATEDRA");
            foreach (DataRow fila in tabla.Rows)
            {
                int codigo = int.Parse(fila["id_catedra"].ToString());
                string descrip = fila["nombre_catedra"].ToString();
                Horarios horario = new Horarios { IdHorarios= int.Parse(fila["id_horario"].ToString())};
                Materias materia = new Materias { IdMateria= int.Parse(fila["id_materia"].ToString()) };
                Docentes docente = new Docentes { Id_Docente= int.Parse(fila["id_docente"].ToString()) };
                Comisiones comision = new Comisiones { IdComision = int.Parse(fila["id_comision"].ToString()) };
                string año = fila["año"].ToString();
                string cuatri = fila["cuatrimestre"].ToString();
                Catedra c = new Catedra(codigo, descrip, horario,materia,docente,comision,año,cuatri);
                lCatedra.Add(c);
            }
            return lCatedra;
        }

        public List<Comisiones> ObtenerComision()
        {
            List<Comisiones> lComision = new List<Comisiones>();
            DataTable tabla = new HelperDao().ObtenerInstancia().Consultar("SP_CONSULTAR_COMISIONES");
            foreach (DataRow fila in tabla.Rows)
            {
                int codigo = (int)fila["id_comision"];
                string desc = fila["nombre_comision"].ToString();
                Comisiones co = new Comisiones(codigo, desc);
                lComision.Add(co);
            }
            return lComision;
        }

        public List<Docentes> ObtenerDocente()
        {
            List<Docentes> lDocente = new List<Docentes>();
            DataTable tabla = new HelperDao().ObtenerInstancia().Consultar("SP_CONSULTAR_DOCENTES");
            foreach (DataRow fila in tabla.Rows)
            {
                int codigo = int.Parse(fila["id_docente"].ToString());
                string nombre = fila["nombre_docente"].ToString();
                string ape = fila["apellido_docente"].ToString();
                DateTime fec = Convert.ToDateTime(fila["fec_nac"]);
                int dni = int.Parse(fila["dni"].ToString());
                string direc = fila["direccion"].ToString();
                int tel = int.Parse(fila["telefono"].ToString());
                string email = fila["email"].ToString();

                Docentes d = new Docentes(codigo, nombre, ape, fec, dni, direc, tel, email);
                lDocente.Add(d);
            }
            return lDocente;
        }

        public List<EstadoMateria> ObtenerEstado()
        {
            List<EstadoMateria> lEstado = new List<EstadoMateria>();
            DataTable tabla = new HelperDao().ObtenerInstancia().Consultar("SP_CONSULTAR_ESTADOMATERIA");
            foreach (DataRow fila in tabla.Rows)
            {
                int codigo = int.Parse(fila["id_estado_materia"].ToString());
                string descrip = fila["nombre_estado_materia"].ToString();
                EstadoMateria e = new EstadoMateria(codigo, descrip);
                lEstado.Add(e);
            }
            return lEstado;
        }

        public List<Estudiantes> ObtenerEstudiante()
        {
            List<Estudiantes> lEstudiante = new List<Estudiantes>();
            DataTable tabla = new HelperDao().ObtenerInstancia().Consultar("SP_CONSULTAR_ESTUDIANTES");
            foreach (DataRow fila in tabla.Rows)
            {
                int codigo = int.Parse(fila["id_estudiante"].ToString());
                string nombre = fila["nombre_estudiante"].ToString();
                string ape = fila["apellido_estudiante"].ToString();
                DateTime fec = Convert.ToDateTime(fila["fecha_nac"]);
                int dni = int.Parse(fila["dni"].ToString());
                string direc = fila["direccion"].ToString();
                int tel = int.Parse(fila["telefono"].ToString());
                string email = fila["email"].ToString();
                string EstCiv = fila["estado_civil"].ToString();
                string SH = fila["situacion_habitacional"].ToString();
                string SL = fila["situacion_laboral"].ToString();
                Estudiantes e = new Estudiantes(codigo,nombre,ape,fec,dni,direc,tel,email,EstCiv,SH,SL);
                lEstudiante.Add(e);
            }
            return lEstudiante;
        }

        public List<Horarios> ObtenerHorario()
        {
            List<Horarios> lHorarios = new List<Horarios>();
            DataTable tabla = new HelperDao().ObtenerInstancia().Consultar("SP_CONSULTAR_HORARIO");
            foreach (DataRow fila in tabla.Rows)
            {
                Horarios h = new Horarios();
                h.IdHorarios = (int)fila["id_horario"];
                h.DiaSemana = fila["dia_semana"].ToString();
                h.HoraInicio = fila["hora_inicio"].ToString();
                h.HoraFin = fila["hora_fin"].ToString();
                h.Aula = (int)fila["aula"];
               
                lHorarios.Add(h);
            }
            return lHorarios;

        }

        public List<Materias> ObtenerMaterias()
        {
            List<Materias> lMateria = new List<Materias>();
            DataTable tabla = new HelperDao().ObtenerInstancia().Consultar("SP_CONSULTAR_MATERIAS");
            foreach (DataRow fila in tabla.Rows)
            {
                int codigo = (int)fila["id_materia"];
                string nombre = fila["nombre_materia"].ToString();
                Carrera carrera = new Carrera { Id_Carrera = Convert.ToInt32(fila["id_carrera"]) };
                Materias m = new Materias(codigo, nombre, carrera);
                lMateria.Add(m);
            }
            return lMateria;
        }
    }
}
