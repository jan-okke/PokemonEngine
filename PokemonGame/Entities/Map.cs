using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using PokemonGame.Static;
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
        private const int TilesetWidth = 8;
        private const int Layers = 3;

        public int Width { get; private set; }
        public int Height { get; private set; }
        private TextureAtlas TilesetAtlas;
        private Tileset Tileset;
        private Dictionary<int, List<int>> TileData; // Layer = key, int = value
        public string Name { get; set; }
        public List<Event> Events;

        private Map() { Events = new(); }

        public Map(string name, int width, int height)
        {
            Name = name;
            Width = width;
            Height = height;
        }
        public bool IsTilePassable(int x, int y)
        {
            if (x < 0 || y < 0 || x > Width || y > Height) return false;
            try { 
                var a = Tileset.GetMovementPermission(TileData[1][x + y * Width + y]);
                var b = Tileset.GetMovementPermission(TileData[2][x + y * Width + y]);
                var c = Tileset.GetMovementPermission(TileData[3][x + y * Width + y]);
                return a && b && c;
            }
            catch (ArgumentOutOfRangeException)
            {
                DebugConsole.WriteLine($"Warning - TileData at {x} : {y} was out of range.", ConsoleColor.Yellow);
                return false;
            }
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
                            case "Events": map.Events.AddRange(value.Split(';').Select(s => Event.Parse(s))); break;
                            case "Tileset": map.TilesetAtlas = new TextureAtlas(ContentCollection.Textures[value], TilesetPixels); break;
                            case "TilesetKey": map.Tileset = TilesetCollection.Tilesets[int.Parse(value)]; break;
                            case "Tiledata1": map.TileData.Add(1, value.Split(',').Select(s => int.Parse(s)).ToList()); break;
                            case "Tiledata2": map.TileData.Add(2, value.Split(',').Select(s => int.Parse(s)).ToList()); break;
                            case "Tiledata3": map.TileData.Add(3, value.Split(',').Select(s => int.Parse(s)).ToList()); break;
                        }
                    }
                    catch (KeyNotFoundException) 
                    {
                        DebugConsole.WriteLine($"error!\nError loading Tileset from {fileName}", ConsoleColor.Red);
                    }
                    catch (NullReferenceException)
                    {
                        DebugConsole.WriteLine("error!\nMissing Initialization!", ConsoleColor.Red);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                DebugConsole.WriteLine($"error!\nError loading file {fileName}", ConsoleColor.Red);
            }
            DebugConsole.WriteLine("done", ConsoleColor.Green);
            return map;
        }
        public void Draw(int width, int height, Player player, SpriteBatch spriteBatch)
        {
            // Draw Map
            for (int layer = 1; layer <= Layers; layer++) 
            {
                var tileData = TileData[layer];
                int x = 0;
                int y = 0;
                foreach (int tile in tileData)
                {
                    if (tile != 0) 
                    spriteBatch.Draw(TilesetAtlas.GetTextureAt(tile % TilesetWidth, tile / TilesetWidth), new Rectangle(x * TilesetPixels - player.DisplayX, y * TilesetPixels - player.DisplayY, TilesetPixels, TilesetPixels), Color.White);
                    x++;
                    if (x > Width) { x = 0; y++; }
                    if (y > Height) { break; }
                }
            }
            // Draw Player
            var playerTexture = player.GetCurrentTexture();
            spriteBatch.Draw(playerTexture, new Rectangle(width / 2 - playerTexture.Width - TilesetPixels / 2, height / 2 - playerTexture.Height - TilesetPixels / 2, playerTexture.Width, playerTexture.Height), Color.White);
            //
        }
    }
}
