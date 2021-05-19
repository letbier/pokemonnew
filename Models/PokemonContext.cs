using Microsoft.EntityFrameworkCore;

namespace pokemonnew.Models
{
    public class PokemonContect
 {
        public DbSet<Entrenador> Entrenadores { get; set; }
        public DbSet<Pueblo> Pueblos { get; set; }
        public DbSet<Region> Regiones { get; set; }
        public DbSet<Pokemon> Pokemones { get; set; }
    

        public PokemonContext(DbContextOptions dco) : base(dco) {

        }
    }
}