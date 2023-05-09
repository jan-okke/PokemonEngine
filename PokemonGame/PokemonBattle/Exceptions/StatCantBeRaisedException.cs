using System;

namespace PokemonGame.PokemonBattle.Exceptions;

public class StatCantBeRaisedException : Exception
{
    public StatCantBeRaisedException() : base("Stat is already at the maximum!") {}
}