using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Context.UsuariosContext
{
    public class UsuariosContext : DbContext
    {
        public UsuariosContext(DbContextOptions<UsuariosContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}