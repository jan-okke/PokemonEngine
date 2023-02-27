using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Validation
{
    public static class MoveValidation
    {
        public static bool Fails(this Move move, Battle battle, bool playerTurn)
        {
            bool moveFails = true;
            bool moveSucess = false;

            var attackingParty = playerTurn ? battle.PlayerParty : battle.EnemyParty;
            var defendingParty = playerTurn ? battle.EnemyParty : battle.PlayerParty;

            var attackingPokemon = attackingParty.GetFirstAlivePokemon();
            var defendingPokemon = defendingParty.GetFirstAlivePokemon();

            var attackingSide = playerTurn ? battle.PlayerSide : battle.EnemySide;
            var defendingSide = playerTurn ? battle.EnemySide : battle.PlayerSide;

            if (defendingPokemon.IsProtected & !move.IgnoresProtect) return moveFails;

            if (move.NameIsAnyOf("Fake Out")) return battle.Turn == 1 ? moveSucess : moveFails;
        }
    }
}
