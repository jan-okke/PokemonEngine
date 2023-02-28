using PokemonGame.PokemonBattle.Entities;
using System;

namespace PokemonGame.PokemonBattle.Exceptions
{
    public class DefenderProtectedException : Exception
    {
        public DefenderProtectedException(Pokemon defender) : base($"{defender} protected itself!") 
        { }
    }
}