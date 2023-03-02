using System.Collections.Generic;
using PokemonGame.PokemonBattle.Enums;
using PokemonGame.PokemonBattle.Extensions;
using System.Linq;

namespace PokemonGame.PokemonBattle.Entities 
{
    public class Pokemon 
    {
        public virtual string Name { get; }
        public int Level { get; internal set; }
        public int Experience { get; internal set; }
        public virtual Ability Ability { get; }
        public Item Item { get; internal set; }
        public List<Move> Moves { get; } = new();
        public virtual Stats BaseStats { get; }
        public Stats IVs { get; } = new();
        public Stats EVs { get; } = new();
        public Stats Stats { get; } = new();
        public Stats StatStages { get; } = new();
        public StatusCondition Status { get; internal set; }
        public List<SecondaryStatusCondition> SecondaryStatusConditions { get; } = new();
        public virtual ExperienceGroup ExperienceGroup { get; }

        public int CurrentHP { get; internal set; }
        public List<Effect> Effects { get; internal set; } = new();
        public virtual List<PokemonType> Types { get; } = new();
        public Gender Gender { get; internal set; }
        public DynamaxState DynamaxState { get; internal set; } = new(0);

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
        public bool Cursed { get; internal set; }
        public Pokemon(string name, int level, Stats baseStats, Ability ability, List<PokemonType> types) 
        {
            Name = name;
            Level = level;
            BaseStats = baseStats;
            Ability = ability;
            Types = types;
            this.CalculateStats();
        }

        public Pokemon(string name, int level)
        {
            Name = name;
            Level = level;
        }

        public Pokemon() 
        {

        }

        public override string ToString()
        {
            return Name;
        }
    }
}