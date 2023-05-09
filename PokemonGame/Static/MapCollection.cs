using PokemonGame.Entities;
using System.Collections.Generic;

namespace PokemonGame.Static;

public class MapCollection
{
    public static Dictionary<int, Map> Maps { get; } = new();
}