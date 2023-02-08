using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using PokemonGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame
{
    public class Initialization
    {
        public static void Initialize()
        {

        }

        public static void LoadContent(ContentManager content)
        {
            ContentCollection.Textures = new()
            {
                { "Outside", content.Load<Texture2D>("Tilesets\\Outside") }
            };
        }
    }
}
