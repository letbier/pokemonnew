using System.Collections.Generic;

namespace pokemonnew.Models
{
    public class Region
    {
        
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Pueblo> Pueblos { get; set; }
    }
}