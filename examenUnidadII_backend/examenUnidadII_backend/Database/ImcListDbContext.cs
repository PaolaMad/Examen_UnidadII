using examenUnidadII_backend.Entites;
using Microsoft.EntityFrameworkCore;

namespace examenUnidadII_backend.Database
{
    public class ImcListDbContext : DbContext
    {
        public ImcListDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ImcEntity> Imc { get; set; }
    }
}
