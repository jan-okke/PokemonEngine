using System.Collections.Generic;
using PokemonGame.PokemonBattle.Enums;
using PokemonGame.PokemonBattle.Extensions;
using System.Linq;

namespace PokemonGame.PokemonBattle.Entities 
{
    public class Pokemon 
    {
        public string Name { get; protected set; }
        public int Level { get; internal set; }
        public int Experience { get; internal set; }
        public Ability Ability { get; internal set; }
        public Item Item { get; internal set; }
        public List<Move> Moves { get; }
        public Stats BaseStats { get; protected set; }
        public Stats IVs { get; }
        public Stats EVs { get; }
        public Stats Stats { get; }
        public Stats StatStages { get; }
        public StatusCondition Status { get; internal set; }
        public List<SecondaryStatusCondition> SecondaryStatusConditions { get;}
        public ExperienceGroup ExperienceGroup { get; }

        public int CurrentHP { get; internal set; }
        public List<Effect> Effects { get; internal set; }
        public List<PokemonType> Types { get; internal set; }
        public Gender Gender { get; internal set; }
        public DynamaxState DynamaxState { get; internal set; }

        public int Weight { get; internal set; }

        public bool IsAlive => CurrentHP > 0;
        public bool IsDynamaxed => DynamaxState.Active;
        public bool IsUnderground => false; // TODO
        public bool IsUnderwater => false; // TODO
        public bool IsProtected => Effects.Any(e => e.HasType(EffectType.Protect, EffectType.BanefulBunker));
        public bool IsFlying => false; // TODO
        public bool IsMinimized => false; // TODO

        public bool Flinched { get; internal set; } // TODO this has to be reset at the end of turn lol
        public bool Infatuated { get; internal set; } // in love
        public bool Confused { get; internal set; }
        public bool Trapped { get; internal set; }
        public bool Muted { get; internal set; } // can not use sound moves xd
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
            Moves = new();
            this.CalculateStats();
        }

        public Pokemon(string name, int level)
        {
            Name = name;
            Level = level;

            EVs = new();
            IVs = new();
            Stats = new();
            Effects = new();
            Moves = new();
        }

        public Pokemon() 
        {
            EVs = new();
            IVs = new();
            Stats = new();
            Effects = new();
            Moves = new();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}