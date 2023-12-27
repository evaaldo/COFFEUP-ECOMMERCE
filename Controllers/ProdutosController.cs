using Ecommerce.Context.BancosContext;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers.ProdutosController
{
    public class ProdutosController : Controller
    {
        private readonly BancosContext _context;

        public ProdutosController(BancosContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var produtos = _context.Produtos.ToList();

            return View(produtos);
        }

        public IActionResult Listagem()
        {
            var produtos = _context.Produtos.ToList();

            return View(produtos);
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();

            return RedirectToAction(nameof(Listagem));
        }

        public IActionResult Deletar(int id)
        {
            var produto = _context.Produtos.Find(id);

            if(produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        [HttpPost]
        public IActionResult Deletar(Produto produto)
        {
            var produtoBanco = _context.Produtos.Find(produto.ID);

            _context.Produtos.Remove(produtoBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Listagem));
        }

        public IActionResult Editar(int id)
        {
            var produto = _context.Produtos.Find(id);

            if(produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        [HttpPost]
        public IActionResult Editar(Produto produto)
        {
            var produtoBanco = _context.Produtos.Find(produto.ID);

            produtoBanco.Nome = produto.Nome;
            produtoBanco.Descricao = produto.Descricao;
            produtoBanco.Preco = produto.Preco;
            produtoBanco.Quantidade = produto.Quantidade;

            _context.Produtos.Update(produtoBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Listagem));
        }

        public IActionResult Comprar(int id)
        {
            var produto = _context.Produtos.Find(id);

            if(produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        [HttpPost]
        public IActionResult Comprar(Produto produto)
        {
            var produtoBanco = _context.Produtos.Find(produto.ID);

            produtoBanco.Quantidade = produto.Quantidade;

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}