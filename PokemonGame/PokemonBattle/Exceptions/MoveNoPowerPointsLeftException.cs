using System;

namespace PokemonGame.PokemonBattle.Exceptions;

public class MoveNoPowerPointsLeftException : Exception
{
    public MoveNoPowerPointsLeftException() : base("Move has no PP left!") {}
}