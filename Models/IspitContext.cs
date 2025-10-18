namespace WebTemplate.Models;

public class IspitContext : DbContext
{
    // Dodaj svoje DbSet kolekcije ovde
    public DbSet<Korisnik> Korisnici { get; set; }
    // public DbSet<Proizvod> Proizvodi { get; set; }
    // ... ostali entiteti

    public IspitContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // Ovde možeš dodati konfiguracije za entitete
    }
}