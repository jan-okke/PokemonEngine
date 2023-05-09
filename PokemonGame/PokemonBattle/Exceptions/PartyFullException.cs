using System;

namespace PokemonGame.PokemonBattle.Exceptions;

public class PartyFullException : Exception
{
    public PartyFullException() : base("Party already full!") {}
}