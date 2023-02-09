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
        private const int TilesetPixels = 32;

        private int Width;
        private int Height;
        private TextureAtlas Tileset;
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
            try 
	    {
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
                            case "Tileset": map.Tileset = new TextureAtlas(ContentCollection.Textures[value], TilesetPixels); break;
                        }
                    }
                    catch (KeyNotFoundException) 
                    {
                        Console.WriteLine($"Error loading Tileset from {fileName}");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Error loading file {fileName}");
            }
            map.TileData = new(); // TODO
            return map; // TODO
        }
        public void Draw(Player player, SpriteBatch spriteBatch)
        {
            
        }
    }
}
