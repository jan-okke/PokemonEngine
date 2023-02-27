using PokemonGame.PokemonBattle.Entities;
using System;

namespace PokemonGame.PokemonBattle.Actions
{
    public static class MoveActions
    {
        public static void ReducePowerPoints(this Move move, int amount = 1)
        {
            move.CurrentPowerPoints -= Math.Max(amount, move.PowerPoints);
        }
    }
}