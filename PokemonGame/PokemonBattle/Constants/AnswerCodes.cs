using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Constants;

public abstract class AnswerCodes
{
    public const int AnswerOk = 0x0000;
    public const int AnswerNotImplemented = -0x0001;

    public const int AnswerCalculationStatusMove = 0x1001;
    public const int AnswerCalculationCriticalHit = 0x1002;
    public const int AnswerCalculationNoEffect = 0x1003;
}