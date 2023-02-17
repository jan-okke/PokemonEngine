using PokemonGame.PokemonBattle.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Entities
{
    public class FieldEffect
    {
        public FieldEffects Effects { get; set; }
        public int Turns { get; set; }

        public bool IsActive => Turns > 0;

        public FieldEffect(FieldEffects effects, int startingTurns)
        {
            Effects = effects;
            Turns = startingTurns;
        }
    }
}
