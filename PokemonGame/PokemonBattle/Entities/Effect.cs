using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Entities;

public class Effect
{
    public EffectType Type { get; }
    private int Turns { get; set; }

    public bool IsActive => Turns > 0;

    public Effect(EffectType type, int startingTurns)
    {
        Type = type;
        Turns = startingTurns;
    }

    public void OnTurnEnd()
    {
        Turns--;
    }
}