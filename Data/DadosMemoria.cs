
using System.Collections.Generic;
using LHPets.Models;

namespace LHPets.Data
{
    public static class DadosMemoria
    {
        public static List<Cliente> Clientes { get; } = new List<Cliente>();

        public static List<Pet> Pets { get; } = new List<Pet>();
    }
}
