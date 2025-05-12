using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using AplicacaoPessoas.Backend.Models; // Adicionado para referenciar o modelo Pessoa

namespace AplicacaoPessoas.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        private static List<Pessoa> _pessoas = new List<Pessoa>();
        private static bool _dadosMockadosCarregados = false;

        public PessoasController()
        {
            if (!_dadosMockadosCarregados)
            {
                for (int i = 1; i <= 30; i++)
                {
                    _pessoas.Add(new Pessoa
                    {
                        Cpf = $"000.000.000-{i:00}",
                        Nome = $"Pessoa Nome {i} Sobrenome {i}",
                        Genero = (i % 2 == 0) ? "Masculino" : "Feminino",
                        Endereco = $"Rua Exemplo {i}, Número {i*10}",
                        Idade = 20 + i,
                        Municipio = $"Cidade Exemplo {i % 5 + 1}",
                        Estado = $"UF{i % 3 + 1}"
                    });
                }
                _dadosMockadosCarregados = true;
            }
        }

        // GET: api/pessoas
        [HttpGet]
        public ActionResult<IEnumerable<Pessoa>> GetPessoas()
        {
            return Ok(_pessoas);
        }
    }
}

