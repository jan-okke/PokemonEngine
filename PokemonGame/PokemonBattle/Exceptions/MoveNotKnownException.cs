using System;

namespace PokemonGame.PokemonBattle.Exceptions;

public class MoveNotKnownException : Exception
{
    public MoveNotKnownException() : base("The Pokemon does not know this move!") {}
}