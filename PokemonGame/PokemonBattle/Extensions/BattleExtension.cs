using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

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
        public static int CalculateDamage(this Battle battle, bool playerTurn, Move move)
        {
            var attackingPokemon = playerTurn ? battle.PlayerParty.GetFirstAlivePokemon() : battle.EnemyParty.GetFirstAlivePokemon();
            var defendingPokemon = playerTurn ? battle.EnemyParty.GetFirstAlivePokemon() : battle.PlayerParty.GetFirstAlivePokemon();
            
            if (move.Category == MoveCategory.Status) return 0; // Status Move

            
            
            return 0; // TODO
        }
    }
}