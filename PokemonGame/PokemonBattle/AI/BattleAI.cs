using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.AI
{
    public static class BattleAI
    {
        public static Move AIChooseMove(this Battle battle)
        {
            var pokemon =  battle.EnemyParty.GetFirstAlivePokemon();
            // this is just max dmg base power move for now.
            return pokemon.GetHighestBPMoves()[0];
        }
    }
}
