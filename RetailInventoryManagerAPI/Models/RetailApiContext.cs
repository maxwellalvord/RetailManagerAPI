using Microsoft.EntityFrameworkCore;

namespace RetailApi.Models
{
  public class RetailApiContext : DbContext
  {
    public DbSet<Item> Items { get; set; }

    public RetailApiContext(DbContextOptions<RetailApiContext> options) : base(options) 
    {
    }
  }
}