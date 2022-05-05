using Microsoft.EntityFrameworkCore;
namespace Categorias.Models
{
    public class CategoriaContexto : DbContext
    {
        public CategoriaContexto(DbContextOptions<CategoriaContexto> dbmysql) : base(dbmysql)
        {

        }
        public DbSet<CategoriaContexto> Categorias { get; set; }
    }

}

