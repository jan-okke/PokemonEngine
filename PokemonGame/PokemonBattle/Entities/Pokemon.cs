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
        public Stats StatStages { get; set; }
        public StatusCondition Status { get; set; }

        public int CurrentHP { get; set; }
        public List<Effect> Effects { get; set; }
        public List<PokemonType> Types { get; set; }
        public Gender Gender { get; set; }
        public DynamaxState DynamaxState { get; set; }

        public bool IsAlive => CurrentHP > 0;
        public bool IsDynamaxed => DynamaxState.Active;
        public bool IsUnderground => false; // TODO
        public bool IsUnderwater => false; // TODO
        public bool IsProtected => false; // TODO

        public bool Flinched { get; set; } // TODO this has to be reset at the end of turn lol
        public bool Trapped { get; set; }

        public Pokemon(string name, int level, Stats baseStats, Ability ability, List<PokemonType> types) 
        {
            Name = name;
            Level = level;
            BaseStats = baseStats;
            Ability = ability;
            Types = types;
            EVs = new();
            IVs = new();
            Stats = new();
            Effects = new();
            this.CalculateStats();
        }

        public Pokemon(string name, int level)
        {
            Name = name;
            Level = level;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}