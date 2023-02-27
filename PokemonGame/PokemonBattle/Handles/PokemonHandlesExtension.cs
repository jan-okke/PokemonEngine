using PokemonGame.PokemonBattle.Enums;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Extensions;
using PokemonGame.PokemonBattle.Actions;
using System;

namespace PokemonGame.PokemonBattle.Handles
{
    public static class PokemonHandlesExtension
    {
        public static void OnLevelUp(this Pokemon pokemon, int oldLevel, int newLevel) { pokemon.Level = newLevel; }

        public static void OnTurnEnd(this Pokemon pokemon) {
            if (!pokemon.IsAlive) throw new Exception("Pokemon not alive");
            foreach (Effect e in pokemon.Effects) {
                if (e.IsActive) e.Turns--;
            }
            if (pokemon.Flinched) pokemon.Flinched = false;
            if (pokemon.DynamaxState.Active) pokemon.DynamaxState.Turns--;

            // check damage from status conditions

            if (pokemon.HasStatusCondition(StatusConditionType.Burned)) {
                pokemon.TakeDamage(1.0 / 16);
            }
            if (pokemon.HasStatusCondition(StatusConditionType.Poisoned)) {
                pokemon.TakeDamage(1.0 / 8);
            }
            if (pokemon.HasStatusCondition(StatusConditionType.BadlyPoisoned)) {
                if (pokemon.Status.CurrentTurn < 1) throw new Exception("Status Turn below 1");
                pokemon.TakeDamage((pokemon.Stats.HP / 16) * pokemon.Status.CurrentTurn);
            }
            if (pokemon.HasStatusCondition(SecondaryStatusConditionType.LeechSeed)) {
                // opponent should be considered here to heal, lol
                pokemon.TakeDamage(1.0 / 8);
            }
            if (pokemon.HasStatusCondition(SecondaryStatusConditionType.Bind, SecondaryStatusConditionType.Clamp, SecondaryStatusConditionType.FireSpin, SecondaryStatusConditionType.Infestation, SecondaryStatusConditionType.MagmaStorm, SecondaryStatusConditionType.SandTomb, SecondaryStatusConditionType.SnapTrap, SecondaryStatusConditionType.ThunderCage, SecondaryStatusConditionType.Whirlpool, SecondaryStatusConditionType.Wrap)) {
                pokemon.TakeDamage(1.0 / 8);
            }
        }
    }
}