using GaleriaDeArte.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GaleriaDeArte.Data
{
    public class GaleriaContext : IdentityDbContext
    {
        public GaleriaContext(DbContextOptions<GaleriaContext> options) : base(options)
        {   }

        public DbSet<Obra> Obra { get; set; }
        public DbSet<Lance> Lance { get; set; }
        public DbSet<Artista> Artista { get; set; }

    }
}
