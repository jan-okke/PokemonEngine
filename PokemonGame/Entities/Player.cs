using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Entities
{
    public class Player
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Texture2D Texture { get; set; }
        public Player(Texture2D texture)
        {
            X = 0;
            Y = 0;
            Texture = texture;
        }
    }
}
