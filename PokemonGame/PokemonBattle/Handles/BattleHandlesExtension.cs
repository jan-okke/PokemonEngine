using PokemonGame.PokemonBattle.Actions;
using PokemonGame.PokemonBattle.Constants;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Extensions;

namespace PokemonGame.PokemonBattle.Handles
{
    public static class BattleHandlesExtension
    {
        public static void HandleMoveTurn(this Battle battle, Pokemon user, Pokemon target, Move firstMove, Move secondMove, bool playerTurn) 
        {
            var answer = battle.CalculateDamage(playerTurn, firstMove);
            battle.CheckEffects(playerTurn, firstMove);
            target.TakeDamage(answer.Value);
            battle.Log(firstMove, answer.Value, answer.AnswerCode == AnswerCodes.Answer_Calculation_CriticalHit, !target.IsAlive);
        }
    }
}