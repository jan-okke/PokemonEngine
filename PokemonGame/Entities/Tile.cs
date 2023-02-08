using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Entities
{
    public class Tile
    {
        public Texture2D Graphic { get; set; }
        public Tile(Texture2D graphic) 
        {
            Graphic = graphic;
        }
    }
}
