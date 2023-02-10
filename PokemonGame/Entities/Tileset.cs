using Microsoft.Xna.Framework.Graphics;
using PokemonGame.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Entities
{
    public class Tileset
    {
        private List<TilePassability> TileData;
        public Tileset() 
        {
            TileData = new List<TilePassability>();
        }
        public bool GetMovementPermission(int tileID)
        {
            return TileData[tileID] == TilePassability.Passable;
        }
        private static TilePassability GetTilePassabilityFromID(int id)
        {
            return id switch
            {
                0 => TilePassability.Passable,
                1 => TilePassability.Impassable,
                _ => throw new ArgumentException(null, nameof(id))
            };
        }
        public static Tileset LoadFromData(string[] data)
        {
            Tileset t = new();
            foreach (string s in data)
            {
                t.TileData.Add(GetTilePassabilityFromID(int.Parse(s)));
            }
            return t;
        }
    }
}
