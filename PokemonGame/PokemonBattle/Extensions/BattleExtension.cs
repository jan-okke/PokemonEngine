using PokemonGame.PokemonBattle.Constants;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonGame.PokemonBattle.Extensions
{
    public static class BattleExtension
    {
        #region Weather
        public static bool SetWeather(this Battle battle, WeatherCondition condition, int startingTurns)
        {
            if (battle.Weather != null &! CanWeatherChanged(battle.Weather.Condition, condition)) return false;
            battle.Weather = new Weather(condition, startingTurns);
            return true;
        }
        private static bool CanWeatherChanged(WeatherCondition oldCondition, WeatherCondition newCondition)
        {
            return true; // TODO
        }
        #endregion
        #region Terrain
        public static bool SetTerrain(this Battle battle, TerrainEffect effect, int startingTurns)
        {
            if (battle.Terrain != null &! CanTerrainChanged(battle.Terrain.Effect, effect)) return false;
            battle.Terrain = new Terrain(effect, startingTurns);
            return true;
        }
        private static bool CanTerrainChanged(TerrainEffect oldEffect, TerrainEffect newEffect)
        {
            return true; // Placeholder, there are no conditions that permit that, but in case something has to be added later.
        }
        #endregion
        public static Answer CalculateDamage(this Battle battle, bool playerTurn, Move move)
        {
            int answerCode = AnswerCodes.Answer_NotImplemented;

            var attackingPokemon = playerTurn ? battle.PlayerParty.GetFirstAlivePokemon() : battle.EnemyParty.GetFirstAlivePokemon();
            var defendingPokemon = playerTurn ? battle.EnemyParty.GetFirstAlivePokemon() : battle.PlayerParty.GetFirstAlivePokemon();
            
            if (move.Category == MoveCategory.Status) return new Answer(AnswerCodes.Answer_Calculation_StatusMove, 0); // Status Move

            bool isCriticalHit = CriticalHitCheck(defendingPokemon, move);

            var power = CalculateMovePower(move);
            var attack = CalculateAttack(attackingPokemon, move);
            var defense = CalculateDefense(defendingPokemon, move);
            var targetMod = CalculateTargetMod(battle, move);
            var parentalBondMod = CalculateParentalBondMod(battle, move);
            var weatherMod = CalculateWeatherMod(battle.Weather, move);
            var glaiveRushMod = CalculateGlaiveRushMod(battle, move);
            var critMod = isCriticalHit ? CalculateCritMod(attackingPokemon, move) : 1;
            var randomMod = CalculateRandomMod(move);
            var stabMod = CalculateStabMod(attackingPokemon, move);
            var effMod = CalculateEffectivityMod(move, defendingPokemon.Types);
            var burnMod = CalculateBurnMod(attackingPokemon, move);
            var otherMod = CalculateOtherMod(battle, move);
            var zMod = CalculateZMod(battle, move);
            var terraMod = CalculateTerraMod(battle, move);

            int damage = (int)(((2 * attackingPokemon.Level / 5 + 2) * power * attack / defense / 50 + 2) * targetMod * parentalBondMod * weatherMod * glaiveRushMod * critMod * randomMod * stabMod * effMod * burnMod * otherMod * zMod * terraMod);

            return new Answer(answerCode, damage); // TODO
        }

        private static bool CriticalHitCheck(Pokemon defender, Move move) => false; // TODO

        private static int CalculateMovePower(Move move) => move.BasePower; // TODO

        private static int CalculateAttack(Pokemon p, Move move) 
            // TODO this does not include if the stat is raised or lowered!
            => move.GetTargetDefense() switch
            {
                Stat.Defense => p.Stats.Attack,
                Stat.SpecialDefense => p.Stats.SpecialAttack,
                _ => throw new ArgumentException(null, nameof(move)),
            };

        private static int CalculateDefense(Pokemon p, Move move)
            // TODO this does not include if the stat is raised or lowered!
            => move.GetTargetDefense() switch
            {
                Stat.Defense => p.Stats.Defense,
                Stat.SpecialDefense => p.Stats.SpecialDefense,
                _ => throw new ArgumentException(null, nameof(move)),
            };
        private static double CalculateTargetMod(Battle battle, Move m) => m.GetTargetCount(battle) > 1 ? 0.75 : 1; // TODO only .5 in Battle Royale

        private static double CalculateParentalBondMod(Battle battle, Move move) => 1; // TODO

        private static double CalculateWeatherMod(Weather weather, Move move)
            // TODO Abilities that boost in weather?
            => weather.Condition switch
            {
                WeatherCondition.None => 1,
                WeatherCondition.Rain => move.Type == PokemonType.Water ? 1.5 : move.Type == PokemonType.Fire ? 0.5 : 1,
                WeatherCondition.Sun => move.Type == PokemonType.Fire ? 1.5 : move.Type == PokemonType.Water ? 0.5 : 1,
                WeatherCondition.Hail => 1,
                WeatherCondition.Sand => 1,
                _ => throw new NotImplementedException(),
            };

        private static double CalculateGlaiveRushMod(Battle battle, Move move) => 1; // TODO

        private static double CalculateCritMod(Pokemon attacker, Move move) => 1.5; // TODO

        private static double CalculateRandomMod(Move move) => move.IsFixedRandom() ? 1 : new Random().Next(85, 101) / 100;

        private static double CalculateStabMod(Pokemon attacker, Move move) => attacker.HasType(move.Type) ? attacker.GetStabModBoost() : 1;

        private static double CalculateEffectivityMod(Move move, PokemonType type) => 1; // TODO

        private static double CalculateEffectivityMod(Move move, List<PokemonType> types) => types.Aggregate(1.0, (result, type) => result *= CalculateEffectivityMod(move, type));
        
        private static double CalculateBurnMod(Pokemon attacker, Move move) => attacker.HasStatusCondition(StatusConditionType.Burned) && move.IsAffectedByBurn() ? move.GetBurnMod() : 1;

        private static double CalculateOtherMod(Battle battle, Move move) => 1; // TODO

        private static double CalculateZMod(Battle battle, Move move) => 1; // TODO

        private static double CalculateTerraMod(Battle battle, Move move) => 1; // TODO
    }
}