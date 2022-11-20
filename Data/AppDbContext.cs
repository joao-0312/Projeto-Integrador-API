using Microsoft.EntityFrameworkCore;
using Projeto_Integrador_API.Models;

namespace Projeto_Integrador_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Usuario> Usuarios { get; set; }
    }
}