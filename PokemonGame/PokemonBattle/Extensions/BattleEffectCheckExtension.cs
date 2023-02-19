using PokemonGame.PokemonBattle.Actions;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Extensions
{
    public static class BattleEffectCheckExtension
    {
        public static void CheckEffects(this Battle battle, bool playerTurn, Move move)
        {
            var attackingParty = playerTurn ? battle.PlayerParty : battle.EnemyParty;
            var defendingParty = playerTurn ? battle.EnemyParty : battle.PlayerParty;

            var attackingPokemon = attackingParty.GetFirstAlivePokemon();
            var defendingPokemon = defendingParty.GetFirstAlivePokemon();

            var attackingSide = playerTurn ? battle.PlayerSide : battle.EnemySide;
            var defendingSide = playerTurn ? battle.EnemySide : battle.PlayerSide;

            switch (move.Name)
            {
                // TODO: abilities that increase the chance
                case "Acid": if (Chance(10)) defendingPokemon.LowerStatStage(Stat.SpecialDefense, 1); break;
                case "Acid Spray": defendingPokemon.LowerStatStage(Stat.SpecialDefense, 2); break;
                case "Air Slash": if (Chance(30)) defendingPokemon.Flinch(); break;
                case "Anchor Shot": defendingPokemon.Trap(); break;
                case "Ancient Power": if (Chance(10)) attackingPokemon.IncreaseAllStatStagesBy(1); break;
                case "Apple Acid": defendingPokemon.LowerStatStage(Stat.Defense, 1); break;
                case "Astonish": if (Chance(30)) defendingPokemon.Flinch(); break;
                case "Aura Wheel": attackingPokemon.IncreaseStatStage(Stat.Speed, 1); break;
                case "Bite": if (Chance(30)) defendingPokemon.Flinch(); break;
                case "Blaze Kick": if (Chance(10)) defendingPokemon.SetStatus(StatusConditionType.Burned, -1); break;
            }
        }
        private static bool Chance(int outOfHundred) => new Random().Next(0, 101) >= outOfHundred;
    }
}
