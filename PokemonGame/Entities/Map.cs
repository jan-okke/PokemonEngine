using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Entities
{
    public class Map
    {
        private int Width;
        private int Height;
        private Texture2D Tileset;
        private Dictionary<int, List<Tile>> TileData; // Layer = key, Tile = value
        public string Name { get; set; }

        private Map() { }

        public Map(string name, int width, int height)
        {
            Name = name;
            Width = width;
            Height = height;
        }
        public static Map LoadFromFile(string fileName)
        {
            string attribute;
            string value;
            Map map = new();
            foreach (string line in File.ReadAllLines(fileName))
            {
                var split = line.Split('=');
                attribute = split[0];
                value = split[1];
                try
                {
                    switch (attribute)
                    {
                        case "Name": map.Name = value; break;
                        case "Width": map.Width = int.Parse(value); break;
                        case "Height": map.Height = int.Parse(value); break;
                        case "Tileset": map.Tileset = ContentCollection.Textures[value]; break;
                    }
                }
                catch (KeyNotFoundException) 
                {
                    Console.WriteLine("ERROR.");
                }
            }
            map.TileData = new(); // TODO
            return map; // TODO
        }
        public void Draw(Player player, SpriteBatch spriteBatch)
        {
            
        }
    }
}
