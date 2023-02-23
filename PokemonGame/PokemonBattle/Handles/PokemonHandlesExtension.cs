using PokemonGame.PokemonBattle.Entities;

namespace PokemonGame.PokemonBattle.Handles
{
    public static class PokemonHandlesExtension
    {
        public static void OnLevelUp(this Pokemon pokemon, int oldLevel, int newLevel) { pokemon.Level = newLevel; }
    }
}