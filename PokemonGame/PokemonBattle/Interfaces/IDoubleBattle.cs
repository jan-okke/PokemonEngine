using PokemonGame.PokemonBattle.Entities;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Interfaces
{
    public interface IDoubleBattle
    {
        List<Pokemon> GetCurrentPlayerBattler();
        List<Pokemon> GetCurrentAIBattler();
    }
}