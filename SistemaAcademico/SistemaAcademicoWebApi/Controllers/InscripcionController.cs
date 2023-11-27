using Microsoft.AspNetCore.Mvc;
using SistemaAcademicoBackend.Entidades;
using SistemaAcademicoBackend.EntidadesDto;
using SistemaAcademicoBackend.Servicios.Implementacion;
using SistemaAcademicoBackend.Servicios.Interfaz;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SistemaAcademicoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InscripcionController : ControllerBase
    {
        private IServicio datos;

        public InscripcionController()
        {
            datos= new Servicio();
        }
        // GET: api/<InscripcionController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<InscripcionController>/5
        [HttpGet("/Catedras")]
        public IActionResult ObtenerCatedras()
        {
            List<Catedra> catedras = null;
            try
            {
                catedras = datos.TraerCatedras();
                return Ok(catedras);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = "ERROR", Response = catedras });

            }
        }
        [HttpGet("/Materias")]
        public IActionResult ObtenerMaterias()
        {
            List<Materias> materias = null;
            try
            {
                materias = datos.TraerMaterias();
                return Ok(materias);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = "ERROR", Response = materias });

            }
        }
        [HttpGet("/Horarios")]
        public IActionResult ObtenerHorarios()
        {
            List<Horarios> horarios = null;
            try
            {
                horarios = datos.TraerHorarios();
                return Ok(horarios);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = "ERROR", Response = horarios });

            }
        }
        [HttpGet("/Docentes")]
        public IActionResult ObtenerDocentes()
        {
            List<Docentes> docentes = null;
            try
            {
                docentes = datos.TraerDocentes();
                return Ok(docentes);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = "ERROR", Response = docentes });

            }
        }
        [HttpGet("/Comision")]
        public IActionResult ObtenerComision()
        {
            List<Comisiones> comisiones = null;
            try
            {
                comisiones = datos.TraerComision();
                return Ok(comisiones);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = "ERROR", Response = comisiones });

            }
        }
        [HttpGet("/Estudiante")]
        public IActionResult ObtenerEstudiante()
        {
            List<Estudiantes> estudiantes = null;
            try
            {
                estudiantes = datos.TraerEstudiante();
                return Ok(estudiantes);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = "ERROR", Response = estudiantes });

            }
        }
        [HttpGet("/Estado")]
        public IActionResult ObtenerEstado()
        {
            List<EstadoMateria> estado = null;
            try
            {
                estado = datos.TraerEstado();
                return Ok(estado);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = "ERROR", Response = estado });

            }
        }

        // POST api/<InscripcionController>
        [HttpPost("/Inscripcion")]
        public IActionResult PostInscripcion(CatedraDTO catedra)
        {
            try
            {
                if (catedra == null)
                {
                    return BadRequest("Datos de catedra incorrectos!");
                }

                return Ok(datos.CrearCatedra(catedra));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        

        // PUT api/<InscripcionController>/5
        [HttpPut("/EditarCatedra")]
        public IActionResult updateCatedra(int nro, CatedraDTO catedra)
        {
            try
            {
                if (catedra == null)
                {
                    return BadRequest("Numero de catedra incorrecto!");
                }
                return Ok(datos.ActualizarCatedra(nro, catedra));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        // DELETE api/<InscripcionController>/5
        [HttpDelete("/EliminarCatedra")]
        public IActionResult DeleteCatedra(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest("Numero de catedra incorrecto!");
                }
                return Ok(datos.BorrarInscripcion(id));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
    }
}
