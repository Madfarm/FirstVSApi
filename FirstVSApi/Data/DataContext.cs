using Microsoft.EntityFrameworkCore;

namespace FirstVSApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
  
    }
}
