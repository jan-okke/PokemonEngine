using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Entities;

public class FieldEffect
{
    public FieldEffects Effects { get; }
    public int Turns { get; internal set; }

    public bool IsActive => Turns > 0;

    public FieldEffect(FieldEffects effects, int startingTurns)
    {
        Effects = effects;
        Turns = startingTurns;
    }
}