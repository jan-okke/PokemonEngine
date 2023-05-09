using PokemonGame.PokemonBattle.Entities;
using System;

namespace PokemonGame.PokemonBattle.Exceptions;

public class MoveFailsException : Exception
{
    public MoveFailsException(Move move) : base($"{move} failed!") 
    { }
}