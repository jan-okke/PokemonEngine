using PokemonGame.PokemonBattle.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Entities
{
    public class StatusCondition
    {
        public StatusConditionType Conditon { get; }
        public int Turns { get; internal set; }

        public int CurrentTurn { get; internal set; }
        public bool IsActive => Turns > 0;

        public StatusCondition(StatusConditionType conditon, int startingTurns)
        {
            Conditon = conditon;
            Turns = startingTurns;
            CurrentTurn = 0;
        }
    }
}
