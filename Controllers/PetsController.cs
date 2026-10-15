
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using LHPets.Data;
using LHPets.Models;

namespace LHPets.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Pet>> GetPets()
        {
            return Ok(DadosMemoria.Pets);
        }

        [HttpPost]
        public ActionResult<Pet> CriarPet(Pet pet)
        {
            bool clienteExiste = DadosMemoria.Clientes
                .Any(c => c.Id == pet.ClienteId);

            if (!clienteExiste)
            {
                return BadRequest("O ClienteId informado não corresponde a um cliente cadastrado.");
            }

            pet.Id = DadosMemoria.Pets.Count + 1;

            DadosMemoria.Pets.Add(pet);

            return Ok(pet);
        }

        [HttpGet("cliente/{clienteId}")]
        public ActionResult<List<Pet>> GetPetsPorCliente(int clienteId)
        {
            bool clienteExiste = DadosMemoria.Clientes
                .Any(c => c.Id == clienteId);

            if (!clienteExiste)
            {
                return NotFound("Cliente não encontrado.");
            }

            List<Pet> petsDoCliente = DadosMemoria.Pets
                .Where(p => p.ClienteId == clienteId)
                .ToList();

            return Ok(petsDoCliente);
        }
    }
}
