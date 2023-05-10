using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Entities;

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