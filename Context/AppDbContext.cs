using LanchesMC.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesMC.Context;
#nullable disable
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Lanche> Lanches { get; set; }
}