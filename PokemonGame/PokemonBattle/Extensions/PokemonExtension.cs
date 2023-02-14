using PokemonGame.PokemonBattle.Entities;

namespace PokemonGame.PokemonBattle.Extensions 
{
    public static class PokemonExtension 
    {
        public static void CalculateStats(this Pokemon pokemon) 
        {
            var baseStats = pokemon.BaseStats;
            var ivs = pokemon.IVs;
            var evs = pokemon.EVs;
            var level = pokemon.Level;
            pokemon.Stats.HP = ((2 * baseStats.HP + ivs.HP + evs.HP / 4) * level / 100) + level + 10;
            pokemon.Stats.Attack = ((2 * baseStats.Attack + ivs.Attack + evs.Attack / 4) * level / 100) + 5; // () * natureMod
        }
    }
}