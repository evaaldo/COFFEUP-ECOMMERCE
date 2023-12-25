using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Context.ProdutosContext
{
    public class ProdutosContext : DbContext
    {
        public ProdutosContext(DbContextOptions<ProdutosContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}