using PokemonGame.PokemonBattle.Entities;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Interfaces
{
    public interface ISingleBattle
    {
        Pokemon GetCurrentPlayerBattler();
        Pokemon GetCurrentAIBattler();
    }
}