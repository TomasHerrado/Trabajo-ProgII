using Microsoft.AspNetCore.Mvc;
using SistemaAcademicoBackend.Entidades;
using SistemaAcademicoBackend.Servicios.Implementacion;
using SistemaAcademicoBackend.Servicios.Interfaz;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SistemaAcademicoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        private IServicio datos;

        public EstudianteController()
        {
            datos = new Servicio();
        }

        // GET: api/<EstudianteController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<EstudianteController>/5

        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<EstudianteController>
        [HttpPost("/InsertarEstudiante")]
        public IActionResult PostEstudiante(Estudiantes estudiante)
        {
            try
            {
                if (estudiante == null)
                {
                    return BadRequest("Datos del estudiante incorrectos!");
                }

                return Ok(datos.CrearEstudiante(estudiante));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        // PUT api/<EstudianteController>/5
        [HttpPut("/EditarEstudiante")]
        public IActionResult updateEstudiante(int nro,Estudiantes estudiantes)
        {
            try
            {
                if (estudiantes == null)
                {
                    return BadRequest("Numero del estudiante es incorrecto!");
                }
                return Ok(datos.ActualizarEstudiante(nro, estudiantes));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        // DELETE api/<EstudianteController>/5
        [HttpDelete("/EliminarEstudiante")]
        public IActionResult DeleteEstudiante(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest("Numero del estudiante es incorrecto!");
                }
                return Ok(datos.BorrarEstudiante(id));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
    }
}
