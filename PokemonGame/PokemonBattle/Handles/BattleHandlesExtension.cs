namespace PokemonGame.PokemonBattle.Handles;

public static class BattleHandlesExtension
{
    /*
    public static void HandleMoveTurn(this Battle battle, Pokemon user, Pokemon target, Move move, bool playerTurn) 
    {
        if (!move.CanUse(playerTurn ? battle.PlayerParty.GetFirstAlivePokemon() : battle.EnemyParty.GetFirstAlivePokemon()) || move.Fails(battle, playerTurn)) {
            return;
        }
        var answer = battle.CalculateDamage(user, target, playerTurn, move);
        battle.CheckEffects(playerTurn, move);
        target.TakeDamage(answer.Value);
        move.ReducePowerPoints(target.HasAbility("Pressure") ? 2 : 1);
        battle.Log(move, answer.Value, answer.AnswerCode == AnswerCodes.AnswerCalculationCriticalHit, !target.IsAlive, answer.Attributes);
    }
    */
}