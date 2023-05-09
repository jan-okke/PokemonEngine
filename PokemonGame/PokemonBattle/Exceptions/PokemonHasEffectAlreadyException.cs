using System;

namespace PokemonGame.PokemonBattle.Exceptions;

public class PokemonHasEffectAlreadyException : Exception
{
    public PokemonHasEffectAlreadyException() : base("The Pokemon already has this Effect!")
    {
    }
}