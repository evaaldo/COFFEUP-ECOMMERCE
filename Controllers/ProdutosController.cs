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
    }
}