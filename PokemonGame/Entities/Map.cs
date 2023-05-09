using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using PokemonGame.Static;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Entities;

public class Map
{
    private const int TilesetPixels = 32;
    private const int TilesetWidth = 8;
    private const int Layers = 3;

    public int MapId { get; set; }
    public int Width { get; private set; }
    public int Height { get; private set; }
    private TextureAtlas _tilesetAtlas;
    private Tileset _tileset;
    private Dictionary<int, List<int>> _tileData; // Layer = key, int = value
    public string Name { get; set; }
    public readonly List<Event> Events;

    private Map()
    {
        Events = new();
    }

    public Map(int mapId, string name, int width, int height)
    {
        MapId = mapId;
        Name = name;
        Width = width;
        Height = height;
    }

    public bool IsTilePassable(int x, int y)
    {
        if (x < 0 || y < 0 || x > Width || y > Height) return false;
        try
        {
            var a = _tileset.GetMovementPermission(_tileData[1][x + y * Width + y]);
            var b = _tileset.GetMovementPermission(_tileData[2][x + y * Width + y]);
            var c = _tileset.GetMovementPermission(_tileData[3][x + y * Width + y]);
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
        var mapId = int.Parse(fileName.Split("GameFiles\\Data\\Maps\\Map")[1].Split(".txt")[0]);
        var map = new Map
        {
            MapId = mapId,
            _tileData = new Dictionary<int, List<int>>()
        };
        try
        {
            foreach (var line in File.ReadAllLines(fileName))
            {
                var split = line.Split('=');
                var attribute = split[0];
                var value = split[1];
                try
                {
                    switch (attribute)
                    {
                        case "Name":
                            map.Name = value;
                            break;
                        case "Width":
                            map.Width = int.Parse(value);
                            break;
                        case "Height":
                            map.Height = int.Parse(value);
                            break;
                        case "Events":
                            map.Events.AddRange(value.Split(';').Select(s => Event.Parse(s)));
                            break;
                        case "Tileset":
                            map._tilesetAtlas = ContentCollection.Splits[value];
                            break;
                        case "TilesetKey":
                            map._tileset = TilesetCollection.Tilesets[int.Parse(value)];
                            break;
                        case "Tiledata1":
                            map._tileData.Add(1, value.Split(',').Select(int.Parse).ToList());
                            break;
                        case "Tiledata2":
                            map._tileData.Add(2, value.Split(',').Select(int.Parse).ToList());
                            break;
                        case "Tiledata3":
                            map._tileData.Add(3, value.Split(',').Select(int.Parse).ToList());
                            break;
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
        for (var layer = 1; layer <= Layers; layer++)
        {
            var tileData = _tileData[layer];
            var x = 0;
            var y = 0;
            foreach (var tile in tileData)
            {
                if (tile != 0)
                    spriteBatch.Draw(_tilesetAtlas.GetTextureAt(tile % TilesetWidth, tile / TilesetWidth),
                        new Rectangle(x * TilesetPixels - player.DisplayX, y * TilesetPixels - player.DisplayY,
                            TilesetPixels, TilesetPixels), Color.White);
                x++;
                if (x > Width)
                {
                    x = 0;
                    y++;
                }

                if (y > Height)
                {
                    break;
                }
            }
        }

        // Draw Player
        var playerTexture = player.GetCurrentTexture();
        spriteBatch.Draw(playerTexture,
            new Rectangle(width / 2 - playerTexture.Width - TilesetPixels / 2,
                height / 2 - playerTexture.Height - TilesetPixels / 2, playerTexture.Width, playerTexture.Height),
            Color.White);
        //
    }
}