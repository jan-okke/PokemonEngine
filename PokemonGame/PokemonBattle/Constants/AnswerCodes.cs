using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Constants
{
    public abstract class AnswerCodes
    {
        public const int Answer_OK = 0x0000;
        public const int Answer_NotImplemented = -0x0001;

        public const int Answer_Calculation_StatusMove = 0x1001;
        public const int Answer_Calculation_CriticalHit = 0x1002;
    }
}
