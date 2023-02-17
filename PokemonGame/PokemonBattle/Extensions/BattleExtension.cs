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
        public static bool IsTerrainEffectActive(this Battle battle, TerrainEffect effect) => battle.Terrain.HasEffect(effect);

        public static bool IsTerrainEffectActive(this Battle battle, params TerrainEffect[] effects) => effects.Any(e => battle.IsTerrainEffectActive(e));
        #endregion
        
        public static bool IsSingleBattle(this Battle battle) => battle.BattleType == BattleType.SingleBattle;
        
        public static Move GetLastMove(this Battle battle) => null; // TODO

        public static bool HasActiveFieldEffect(this Battle battle, FieldEffects effect) => battle.FieldEffects.Any(f => f.Effects == effect && f.IsActive);

        public static bool HasActiveFieldEffect(this Battle battle, params FieldEffects[] effects) => effects.Any(e => battle.HasActiveFieldEffect(e));
    }
}