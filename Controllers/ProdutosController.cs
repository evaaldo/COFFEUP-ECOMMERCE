using Ecommerce.Context.BancosContext;
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
            return View();
        }
    }
}