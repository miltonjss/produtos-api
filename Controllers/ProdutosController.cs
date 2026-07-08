using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProdutosAPI.Data;
using ProdutosAPI.Models;

namespace ProdutosAPI.Controllers
{
    [ApiController]
    [Route("api/v1/produtos")]
    public class ProdutosController : Controller
    {
        private readonly Connection _context;

        public ProdutosController(Connection context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
        {
            return await _context.Produtos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> GetProdutoId(int id)
        {
            var existing = await _context.Produtos.FirstOrDefaultAsync(e => e.id == id);
            if (existing == null)
            {
                return NotFound();
            }
            return existing;

        }
        [HttpPost]
        public async Task<IActionResult> PostProdutos(Produto produto)
        {
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProdutos(int id, Produto produto)
        {
            if (id != produto.id)
            {
                return BadRequest("ID informado não é igual ao do produto");
            }

            var produtoEncontrado = await _context.Produtos.FindAsync(id);

            if (produtoEncontrado == null)
            {
                return NotFound("Produto não existe no banco de dados");
            }
            else
            {
                produtoEncontrado.nome = produto.nome;
                produtoEncontrado.preco = produto.preco;
                produtoEncontrado.quantidade = produto.quantidade;
                await _context.SaveChangesAsync();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduto(int id)
        {
            var produtoEncontrado = await _context.Produtos.FindAsync(id);
            if (produtoEncontrado == null)
                return NotFound("ID não existe no banco de dados");

            _context.Produtos.Remove(produtoEncontrado);
            await _context.SaveChangesAsync();


            return NoContent();
        }
    }
}
