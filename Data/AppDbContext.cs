using Microsoft.EntityFrameworkCore;
using TerminalBackend.Models;

namespace TerminalBackend.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<OrdemServico> OrdensServico { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
}