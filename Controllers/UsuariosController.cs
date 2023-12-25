using Ecommerce.Context.BancosContext;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers.UsuariosController
{
    public class UsuariosController : Controller
    {
        private readonly BancosContext _context;

        public UsuariosController(BancosContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string nome, string senha)
        {
            var usuarios = _context.Usuarios.ToList();

            foreach(Usuario usuario in usuarios)
            {
                if(nome == usuario.Nome && senha == usuario.Senha)
                {
                    // return RedirectToAction(nameof(Index));
                    return RedirectToAction("Listagem", "Produtos");
                }
            }

            TempData["MensagemLogin"] = "Login/Senha incorreto(s). Tente novamente.";
            return RedirectToAction(nameof(Index));
        }
    }
}