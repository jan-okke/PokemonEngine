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
            DebugConsole.Write("Initializing...", ConsoleColor.Green);
            DebugConsole.WriteLine("done", ConsoleColor.Green);
        }

        public static void LoadContent(ContentManager content)
        {
            DebugConsole.Write("Loading content...", ConsoleColor.Green);
            ContentCollection.Textures = new()
            {
                { "Outside", content.Load<Texture2D>("Tilesets\\Outside") },
                { "Player", content.Load<Texture2D>("Characters\\boy_run") }
            };
            DebugConsole.WriteLine("done", ConsoleColor.Green);
        }
    }
}
