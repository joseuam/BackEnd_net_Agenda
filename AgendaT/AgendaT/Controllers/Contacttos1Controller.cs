using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using AgendaT.Models;
using AgendaT.Repositorios;
using Microsoft.AspNetCore.Cors;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AgendaT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Contacttos1Controller : ControllerBase
    {
        [EnableCors("AnotherPolicy")]
        [HttpGet]
        public IActionResult Get()
        {
            RPContacto rpCli = new RPContacto();
            return Ok(rpCli.ObtenerContactos());
        }

        [EnableCors("AnotherPolicy")]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            RPContacto rpCli = new RPContacto();

            var cliRet = rpCli.ObtenerContacto(id);

            if (cliRet == null)
            {
                var nf = NotFound("El cliente " + id.ToString() + " no existe.");
                return nf;
            }

            return Ok(cliRet);
        }

        [EnableCors("AnotherPolicy")]
        [HttpPost("agregar")]
        public IActionResult AgregarCliente(Contacto nuevoCliente)
        {
            RPContacto rpCli = new RPContacto();
            rpCli.Agregar(nuevoCliente);
            return CreatedAtAction(nameof(AgregarCliente), nuevoCliente);
        }

        [EnableCors("AnotherPolicy")]
        [HttpPut("Actualizar")]
        public IActionResult ActualizarContacto(Contacto contAct)
        {
            RPContacto rpCli = new RPContacto();
            return Ok(rpCli.Actualizar(contAct));
        }

        [EnableCors("AnotherPolicy")]
        [HttpDelete("{id}")]
        public IActionResult EliminarContacto(int id)
        {
            RPContacto rpCli = new RPContacto();
            return Ok(rpCli.Eliminar(id));
        }

    }
}
