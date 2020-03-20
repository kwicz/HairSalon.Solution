using Microsoft.EntityFrameworkCore;

namespace EauClairesSalon.Models
{
  public class EauClairesSalonContext : DbContext
  {
    public virtual DbSet<Stylists> Stylists { get; set; }
    public DbSet<Clients> Clients { get; set; }

    public EauClairesSalonContext(DbContextOptions options) : base(options) { }
  }
}