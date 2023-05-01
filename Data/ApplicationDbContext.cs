using Microsoft.EntityFrameworkCore;
using Projet_asp.Models;

namespace Projet_asp.data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options)  
    {
            
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Chef> Chefs { get; set; }
    public DbSet<Menu> Menus { get; set; }
    public DbSet<Plat> Plats { get; set; }
    public DbSet<Contact> Contacts { get; set; }
}
