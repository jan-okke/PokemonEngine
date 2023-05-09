using PokemonGame.PokemonBattle.Entities;
using System;

namespace PokemonGame.PokemonBattle.Exceptions;

public class PokemonNotAliveException : Exception
{
    public PokemonNotAliveException(Pokemon p) : base($"{p} not alive!") {}
}