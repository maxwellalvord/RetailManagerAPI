using Microsoft.EntityFrameworkCore

namespace RetailInventoryManagerAPI.Models
{
  public class RetailInventoryManagerAPIContext : DbContext
  {
    public DbSet<Item> Items { get; set; }

    public RetailInventoryManagerAPIContext(DbContextOptions<RetailInventoryManagerAPIContext> options) : base(options) 
    {
    }
  }
}