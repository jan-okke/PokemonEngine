using PokemonGame.Entities;
using System.Collections.Generic;

namespace PokemonGame.Static;

public class TilesetCollection
{
    public static Dictionary<int, Tileset> Tilesets { get; } = new();
}