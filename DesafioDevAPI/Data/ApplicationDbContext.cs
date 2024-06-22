using DesafioDevAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioDevAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) {}
 
        
        public DbSet<ClienteModel> Cliente { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

    }
}
