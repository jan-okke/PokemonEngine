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
        
        public static bool IsWeatherConditionActive(this Battle battle, WeatherCondition condition) => battle.Weather.IsConditionActive(condition);

        public static bool IsWeatherConditionActive(this Battle battle, params WeatherCondition[] conditions) => battle.Weather.IsConditionActive(conditions);
        
        #endregion
        #region Terrain
        
        public static bool IsTerrainEffectActive(this Battle battle, TerrainEffect effect) => battle.Terrain.HasEffect(effect);

        public static bool IsTerrainEffectActive(this Battle battle, params TerrainEffect[] effects) => effects.Any(e => battle.IsTerrainEffectActive(e));
        #endregion
        
        public static bool IsSingleBattle(this Battle battle) => battle.BattleType == BattleType.SingleBattle;
        
        public static Move GetLastMove(this Battle battle) {
            var data = battle.Log.Data.Last().Data;
            return data["USED_MOVE_NAME"] as Move;
        }

        public static bool HasActiveFieldEffect(this Battle battle, FieldEffects effect) => battle.FieldEffects.Any(f => f.Effects == effect && f.IsActive);

        public static bool HasActiveFieldEffect(this Battle battle, params FieldEffects[] effects) => effects.Any(e => battle.HasActiveFieldEffect(e));

        public static void Log(this Battle battle, Move move, int damage, bool critical, bool kill) 
        {
            var log = battle.Log;
            var battleData = new BattleData();
            var data = battleData.Data;
            data.Add("TURN", battle.Turn);
            data.Add("USED_MOVE_NAME", move);
            data.Add("USED_MOVE_DAMAGE", damage);
            data.Add("USED_MOVE_CRITICAL_HIT", critical);
            data.Add("USED_MOVE_KILLED", kill);

            log.Data.Add(battleData);
        } 
    }
}