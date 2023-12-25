using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Context.BancosContext
{
    public class BancosContext : DbContext
    {
        public BancosContext(DbContextOptions<BancosContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}