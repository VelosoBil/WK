using Microsoft.EntityFrameworkCore;

namespace Prod.Models
{
    public class ProdutoContexto : DbContext
    {
        public ProdutoContexto(DbContextOptions<ProdutoContexto> dbmysql) : base(dbmysql)
        {

        }
        public DbSet<ProdutoContexto> Prod { get; set; }
    }
}
