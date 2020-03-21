using Microsoft.EntityFrameworkCore;

namespace EauClairesSalon.Models
{
  public class EauClairesSalonContext : DbContext
  {
    public virtual DbSet<Stylist> Stylists { get; set; }
    public DbSet<Client> Clients { get; set; }

    public EauClairesSalonContext(DbContextOptions options) : base(options) { }
  }
}