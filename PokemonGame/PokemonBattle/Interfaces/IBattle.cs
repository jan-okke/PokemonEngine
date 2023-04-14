using PokemonGame.PokemonBattle.Entities;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Interfaces
{
    public interface IBattle
    {
        List<Pokemon> GetPlayerParty();
        List<Pokemon> GetAIParty();
        bool IsBattleOver();
    }
}