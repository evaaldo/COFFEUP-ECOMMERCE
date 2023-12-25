using Ecommerce.Context.UsuariosContext;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers.UsuariosController
{
    public class UsuariosController : Controller
    {
        private readonly UsuariosContext _context;

        public UsuariosController(UsuariosContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}