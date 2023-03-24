using PokemonGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Static
{
    public class TilesetCollection
    {
        public static Dictionary<int, Tileset> Tilesets { get; } = new Dictionary<int, Tileset>();
    }
}
