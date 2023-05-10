using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Entities;

public class SecondaryStatusCondition
{
    public SecondaryStatusConditionType Condition { get; }
    private int Turns { get; set; }
    private int CurrentTurn { get; set; }

    public bool IsActive => Turns > 0;

    public SecondaryStatusCondition(SecondaryStatusConditionType conditionType, int startingTurns) {
        Condition = conditionType;
        Turns = startingTurns;
        CurrentTurn = 0;
    }

    public void OnTurnEnd()
    {
        CurrentTurn++;
        Turns--;
    }
}