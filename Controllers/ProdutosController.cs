using Ecommerce.Context.ProdutosContext;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers.ProdutosController
{
    public class ProdutosController : Controller
    {
        private readonly ProdutosContext _context;

        public ProdutosController(ProdutosContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}