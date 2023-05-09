using System;

namespace PokemonGame.PokemonBattle.Exceptions;

public class StatusAlreadyActiveException : Exception
{
    public StatusAlreadyActiveException() : base("Pokemon already has an active status condition!") {}
}