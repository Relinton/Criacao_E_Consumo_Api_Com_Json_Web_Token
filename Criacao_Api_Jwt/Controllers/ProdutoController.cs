using Criacao_Api_Jwt.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Criacao_Api_Jwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public ActionResult <IEnumerable<string>> BuscaTodos()
        {
            List<Produto> produtos = new List<Produto>();
            produtos.Add(new Produto() { Id = 1, Nome = "Arroz" });
            produtos.Add(new Produto() { Id = 1, Nome = "Feijão" });
            produtos.Add(new Produto() { Id = 1, Nome = "Macarrão" });
            produtos.Add(new Produto() { Id = 1, Nome = "Carne" });

            return new ObjectResult(produtos);
        }

        [Authorize]
        [HttpGet("{id}")]
        public ActionResult<string> BuscaPorId(int id)
        {
            return "Arroz";
        }
    }
}
