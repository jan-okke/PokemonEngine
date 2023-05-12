using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Entities;

public class StatusCondition
{
    public StatusConditionType Condition { get; }
    private int Turns { get; set; }

    public int CurrentTurn { get; private set; }
    public bool IsActive => Turns > 0;

    public StatusCondition(StatusConditionType condition, int startingTurns)
    {
        Condition = condition;
        Turns = startingTurns;
        CurrentTurn = 0;
    }

    public void OnEndTurn()
    {
        CurrentTurn++;
        Turns--;
    }
}