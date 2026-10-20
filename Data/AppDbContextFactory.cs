using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TerminalBackend.Data;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        // Aqui a gente diz onde o banco vai ser criado
        optionsBuilder.UseSqlite("Data Source=terminal.db");

        return new AppDbContext(optionsBuilder.Options);
    }
}