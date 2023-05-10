using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Extensions;

public static class TerrainExtension
{
    public static bool HasEffect(this Terrain terrain, TerrainEffect effect) => terrain.Effect == effect;
}