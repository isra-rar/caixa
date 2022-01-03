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

        [HttpPut("{id:guid}")]
        public IActionResult UpdateProduto(Guid id, Produto produto)
        {
            if (produto == null)
                return BadRequest();

            try
            {
                _produtoRepository.Update(produto, id);
                return NoContent();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduto(Guid id)
        {
            try
            {
                _produtoRepository.Delete(id);
                return NoContent();
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
