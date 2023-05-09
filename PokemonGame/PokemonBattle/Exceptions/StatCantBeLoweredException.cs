using System;

namespace PokemonGame.PokemonBattle.Exceptions;

public class StatCantBeLoweredException : Exception
{
    public StatCantBeLoweredException() : base("Stat is already at the minimum!") {}
}