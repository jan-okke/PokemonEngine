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
        
        #endregion
        #region Terrain
        
        public static bool IsTerrainEffectActive(this Battle battle, TerrainEffect effect) => battle.Terrain.HasEffect(effect);

        public static bool IsTerrainEffectActive(this Battle battle, params TerrainEffect[] effects) => effects.Any(e => battle.IsTerrainEffectActive(e));
        #endregion
        
        public static bool IsSingleBattle(this Battle battle) => battle.BattleType == BattleType.SingleBattle;
        
        public static Move GetLastMove(this Battle battle) => null; // TODO

        public static bool HasActiveFieldEffect(this Battle battle, FieldEffects effect) => battle.FieldEffects.Any(f => f.Effects == effect && f.IsActive);

        public static bool HasActiveFieldEffect(this Battle battle, params FieldEffects[] effects) => effects.Any(e => battle.HasActiveFieldEffect(e));

        public static void Log(this Battle battle, Move move, int damage, bool critical, bool kill) 
        {
            var log = battle.Log;
            var battleData = new BattleData();
            var data = battleData.Data;
            data.Add("TURN", battle.Turn.ToString());
            data.Add("USED_MOVE_NAME", move.Name);
            data.Add("USED_MOVE_DAMAGE", damage.ToString());
            data.Add("USED_MOVE_CRITICAL_HIT", critical.ToString());
            data.Add("USED_MOVE_KILLED", kill.ToString());

            log.Data.Add(battleData);
        } 
    }
}