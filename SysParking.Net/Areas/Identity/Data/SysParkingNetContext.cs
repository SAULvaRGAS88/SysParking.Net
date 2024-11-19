using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SysParking.Net.Areas.Identity.Data;
using SysParking.Net.Models;

namespace SysParking.Net.Data;

public class SysParkingNetContext : IdentityDbContext<UsuarioModel>
{
    public SysParkingNetContext(DbContextOptions<SysParkingNetContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<SysParking.Net.Models.Carro>? Carro { get; set; }

    public DbSet<SysParking.Net.Models.Estacionamento>? Estacionamento { get; set; }

    public DbSet<SysParking.Net.Models.Gestor>? Gestor { get; set; }

    public DbSet<SysParking.Net.Models.Nota>? Nota { get; set; }

    public DbSet<SysParking.Net.Models.TabalaPreco>? TabalaPreco { get; set; }

    public DbSet<SysParking.Net.Models.Usuario>? Usuario { get; set; }
}
