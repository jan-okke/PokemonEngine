using PokemonGame.PokemonBattle.Actions;
using PokemonGame.PokemonBattle.Constants;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Extensions;
using PokemonGame.PokemonBattle.Validation;

namespace PokemonGame.PokemonBattle.Handles
{
    public static class BattleHandlesExtension
    {
        public static void HandleMoveTurn(this Battle battle, Pokemon target, Move move, bool playerTurn) 
        {
            if (move.Fails(battle, playerTurn)) {
                return;
            }
            var answer = battle.CalculateDamage(playerTurn, move);
            battle.CheckEffects(playerTurn, move);
            target.TakeDamage(answer.Value);
            move.ReducePowerPoints(target.HasAbility("Pressure") ? 2 : 1);
            battle.Log(move, answer.Value, answer.AnswerCode == AnswerCodes.Answer_Calculation_CriticalHit, !target.IsAlive);
        }
    }
}