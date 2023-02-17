using System.Collections.Generic;
using PokemonGame.PokemonBattle.Enums;
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
        public StatusCondition Status { get; set; }

        public int CurrentHP { get; set; }
        public List<PokemonType> Types { get; set; }

        public bool IsAlive => CurrentHP > 0;

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
        public override string ToString()
        {
            return Name;
        }
    }
}