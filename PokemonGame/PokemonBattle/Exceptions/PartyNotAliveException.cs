using System;

namespace PokemonGame.PokemonBattle.Exceptions;

public class PartyNotAliveException : Exception
{
    public PartyNotAliveException() : base("Party is not alive!") {}
}