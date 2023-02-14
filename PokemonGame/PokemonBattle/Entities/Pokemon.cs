using System.Collections.Generic;
using PokemonGame.PokemonBattle.Extensions;

namespace PokemonGame.PokemonBattle.Entities 
{
    public class Pokemon 
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public Ability Ability { get; set; }
        public Item Item { get; set; }
        public List<Move> Moves { get; set; }
        public Stats BaseStats { get; set; }
        public Stats IVs { get; set; }
        public Stats EVs { get; set; }
        public Stats Stats { get; set; }

        public Pokemon(string name, int level, Stats baseStats) 
        {
            Name = name;
            Level = level;
            BaseStats = baseStats;
            EVs = new();
            IVs = new();
            Stats = new();
            this.CalculateStats();
        }
    }
}