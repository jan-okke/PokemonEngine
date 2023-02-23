using PokemonGame.PokemonBattle.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Entities
{
    public class Effect
    {
        public EffectType Type { get; }
        public int Turns { get; internal set; }

        public bool IsActive => Turns > 0;

        public Effect(EffectType type, int startingTurns)
        {
            Type = type;
            Turns = startingTurns;
        }
    }
}
