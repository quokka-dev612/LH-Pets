
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using LHPets.Data;
using LHPets.Models;

namespace LHPets.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Cliente>> GetClientes()
        {
            return Ok(DadosMemoria.Clientes);
        }

        [HttpPost]
        public ActionResult<Cliente> CriarCliente(Cliente cliente)
        {
            cliente.Id = DadosMemoria.Clientes.Count + 1;

            DadosMemoria.Clientes.Add(cliente);

            return Ok(cliente);
        }
    }
}
