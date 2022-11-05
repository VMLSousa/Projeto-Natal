using Microsoft.EntityFrameworkCore;

namespace ProjetoNatal.Server.dbcontext
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<User> user { get; set; }
    }
}
