using PokemonGame.PokemonBattle.Entities;
using System.Linq;

namespace PokemonGame.PokemonBattle.Extensions;

public static class ItemExtension
{
    public static bool CanGetRemoved(this Item item) => true; // TODO

    public static bool HasName(this Item item, string name) => item.Name == name;

    public static bool HasName(this Item item, params string[] names) => names.Any(item.HasName);
}