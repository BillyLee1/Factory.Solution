using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : dbContextOptions
  {
    public DbSet<Engineer> Engineers { get; set; }
    public DbSet<Machine> Machines { get; set; }

    public FactoryContext(dbContextOptions options) : base(options) { }
  }
}
