using PokemonGame.PokemonBattle.Entities;
using System;

namespace PokemonGame.PokemonBattle.Exceptions
{
    public class MoveHasNoEffectException : Exception
    {
        public MoveHasNoEffectException(Move move) : base($"{move} had no effect..") 
        { }
    }
}