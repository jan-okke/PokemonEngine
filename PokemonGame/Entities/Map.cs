using Microsoft.Xna.Framework;
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
        private const int Layers = 3;

        private int Width;
        private int Height;
        private TextureAtlas Tileset;
        private Dictionary<int, List<int>> TileData; // Layer = key, int = value
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
            DebugConsole.Write($"Loading map {fileName}...", ConsoleColor.Green);
            string attribute;
            string value;
            Map map = new();
            map.TileData = new();
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
                            case "Tiledata1": map.TileData.Add(1, value.Split(',').Select(s => int.Parse(s)).ToList()); break;
                            case "Tiledata2": map.TileData.Add(2, value.Split(',').Select(s => int.Parse(s)).ToList()); break;
                            case "Tiledata3": map.TileData.Add(3, value.Split(',').Select(s => int.Parse(s)).ToList()); break;
                        }
                    }
                    catch (KeyNotFoundException) 
                    {
                        DebugConsole.WriteLine($"Error loading Tileset from {fileName}", ConsoleColor.Red);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                DebugConsole.WriteLine($"Error loading file {fileName}", ConsoleColor.Red);
            }
            DebugConsole.WriteLine("done", ConsoleColor.Green);
            return map;
        }
        public void Draw(int width, int height, Player player, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            // Draw Map
            for (int layer = 1; layer <= Layers; layer++) 
            {
                var tileData = TileData[layer];
                int x = 0;
                int y = 0;
                foreach (int tile in tileData)
                {
                    if (tile != 0) 
                    spriteBatch.Draw(Tileset.GetTextureAt(tile % Width, tile / Width), new Rectangle(x * TilesetPixels - player.X, y * TilesetPixels + player.Y, TilesetPixels, TilesetPixels), Color.White);
                    x++;
                    if (x > Width) { x = 0; y++; }
                    if (y > Height) { break; }
                }
            }
            // Draw Player
            var playerTexture = player.GetCurrentTexture();
            spriteBatch.Draw(playerTexture, new Rectangle(width / 2 - playerTexture.Width, height / 2 - playerTexture.Height, playerTexture.Width, playerTexture.Height), Color.White);
            //
            spriteBatch.End();
        }
    }
}
