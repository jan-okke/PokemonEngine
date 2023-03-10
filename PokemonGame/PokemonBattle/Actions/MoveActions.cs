using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Exceptions;
using System;

namespace PokemonGame.PokemonBattle.Actions
{
    public static class MoveActions
    {
        public static void ReducePowerPoints(this Move move, int amount = 1)
        {
            if (move.CurrentPowerPoints == 0) throw new MoveNoPowerPointsLeftException();
            move.CurrentPowerPoints -= Math.Min(amount, move.PowerPoints);
        }

        public static void RestorePowerPoints(this Move move, int amount)
        {
            move.CurrentPowerPoints += Math.Min(amount, move.PowerPoints - move.CurrentPowerPoints);
        }
        public static void RestorePowerPoints(this Move move)
        {
            move.CurrentPowerPoints = move.PowerPoints;
        }
    }
}