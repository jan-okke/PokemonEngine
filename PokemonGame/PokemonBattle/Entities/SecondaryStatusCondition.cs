using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Entities;

public class SecondaryStatusCondition
{
    public SecondaryStatusConditionType Condition { get; }
    public int Turns { get; internal set; }
    public int CurrentTurn { get; internal set; }

    public bool IsActive => Turns > 0;

    public SecondaryStatusCondition(SecondaryStatusConditionType conditionType, int startingTurns) {
        Condition = conditionType;
        Turns = startingTurns;
        CurrentTurn = 0;
    }
}