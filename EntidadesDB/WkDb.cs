using Microsoft.EntityFrameworkCore;
namespace WK.Dados
{
    public class dbWk : DbContext
    {
        public dbWk(DbContextOptions<dbWk> dbmysql) 
            : base(dbmysql)
        {}
    }
}
