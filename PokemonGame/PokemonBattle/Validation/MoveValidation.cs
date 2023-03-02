using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using PokemonGame.PokemonBattle.Extensions;
using PokemonGame.PokemonBattle.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Validation
{
    public static class MoveValidation
    {
        public static bool CanUse(this Move move, Pokemon user) {
            if (user.HasStatusCondition(StatusConditionType.Frozen)) return false;
            if (user.HasStatusCondition(StatusConditionType.Sleeping)) return false;
            if (user.Infatuated) return false;
            if (user.HasStatusCondition(StatusConditionType.Paralyzed)) return false;
            if (user.Flinched) return false;
            if (user.Muted && move.IsSoundMove) return false;
            
            return true;
        }

        public static bool Fails(this Move move, Battle battle, bool playerTurn)
        {
            // bool moveFails = true;
            bool moveSucess = false;

            var attackingParty = playerTurn ? battle.PlayerParty : battle.EnemyParty;
            var defendingParty = playerTurn ? battle.EnemyParty : battle.PlayerParty;

            var attackingPokemon = attackingParty.GetFirstAlivePokemon();
            var defendingPokemon = defendingParty.GetFirstAlivePokemon();

            var attackingSide = playerTurn ? battle.PlayerSide : battle.EnemySide;
            var defendingSide = playerTurn ? battle.EnemySide : battle.PlayerSide;

            if (defendingPokemon.IsProtected & !move.IgnoresProtect) throw new DefenderProtectedException(defendingPokemon);
            if (move.NameIsAnyOf("Fake Out") && battle.Turn != 1) throw new MoveFailsException(move); // TODO, this should not be battle turn 1 but move turn 1

            return moveSucess;
        }
    }
}
