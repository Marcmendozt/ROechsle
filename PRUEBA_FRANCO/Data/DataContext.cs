using Microsoft.EntityFrameworkCore;

namespace PRUEBA_FRANCO.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> DCOptions) : base(DCOptions) { }

        public DbSet<employee> employee { get; set; }
    }
}
