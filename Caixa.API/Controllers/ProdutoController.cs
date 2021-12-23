using Caixa.Domain.Entities;
using Caixa.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Caixa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpGet("{id}")]
        public IActionResult GetProduto(Guid id)
        {
            try
            {
                var produto = _produtoRepository.Get(id);
                if (produto == null)
                    return NotFound();

                return Ok(produto);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        [HttpPost]
        public IActionResult CreateProduto([FromBody] Produto produto)
        {
            try
            {
                if (produto == null)
                    return BadRequest();

                _produtoRepository.Create(produto);
                return Created($"{Request.Path}/{produto.Id}", produto);
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
