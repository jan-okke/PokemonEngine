using PokemonGame.PokemonBattle.Entities;
using System.Linq;
using System.Collections.Generic;

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
            pokemon.Stats.Defense = ((2 * baseStats.Defense + ivs.Defense + evs.Defense / 4) * level / 100) + 5; // () * natureMod
            pokemon.Stats.SpecialAttack = ((2 * baseStats.SpecialAttack + ivs.SpecialAttack + evs.SpecialAttack / 4) * level / 100) + 5; // () * natureMod
            pokemon.Stats.SpecialDefense = ((2 * baseStats.SpecialDefense + ivs.SpecialDefense + evs.SpecialDefense / 4) * level / 100) + 5; // () * natureMod
            pokemon.Stats.Speed = ((2 * baseStats.Speed + ivs.Speed + evs.Speed / 4) * level / 100) + 5; // () * natureMod
        }

        public static int GetBST(this Pokemon pokemon) 
        {
            return pokemon.BaseStats.Sum();
        }

        public static List<Move> GetHighestBPMoves(this Pokemon pokemon)
        {
            return pokemon.Moves.Where(m => m.BasePower == pokemon.Moves.Max(m => m.BasePower)).ToList();
        }
    }
}