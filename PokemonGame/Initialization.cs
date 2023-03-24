using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using PokemonGame.Entities;
using PokemonGame.Static;
using System;
using System.Collections.Generic;
using System.IO;
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
    
            ContentCollection.Textures.Add("Outside", content.Load<Texture2D>("Tilesets\\Outside"));
            ContentCollection.Textures.Add("Player", content.Load<Texture2D>("Characters\\boy_run"));

            DebugConsole.WriteLine("done", ConsoleColor.Green);
        }
        public static void LoadTilesets()
        {
            DebugConsole.Write("Loading tilesets...", ConsoleColor.Green);
            string attribute;
            string value;
            foreach (string line in File.ReadAllLines("GameFiles\\Data\\TilesetData.txt"))
            {
                var split = line.Split('=');
                attribute = split[0];
                value = split[1];
                TilesetCollection.Tilesets.Add(int.Parse(attribute), Tileset.LoadFromData(value.Split(',')));
            }
            DebugConsole.WriteLine("done", ConsoleColor.Green);
        }

        public static void LoadMaps()
        {
            var mapPath = "GameFiles\\Data\\Maps";
            foreach (string file in Directory.GetFiles(mapPath))
            {
                //int mapID = int.Parse(file.Split("GameFiles\\Data\\Maps\\Map")[1].Split(".txt")[0]);
                Map map = Map.LoadFromFile(file);
                MapCollection.Maps.Add(map.MapID, map);
            }
        }
    }
}
