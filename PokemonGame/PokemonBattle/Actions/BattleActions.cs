using PokemonGame.PokemonBattle.AI;
using PokemonGame.PokemonBattle.Constants;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using PokemonGame.PokemonBattle.Extensions;
using PokemonGame.PokemonBattle.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Actions
{
    public static class BattleActions
    {

        public static Battle StartWildBattle(PokemonParty playerParty, string pokemonName, int level)
        {
            var opponent = new Pokemon(pokemonName, level);
            var battle = new Battle(playerParty, new PokemonParty(new List<Pokemon> { opponent }));
            battle.SetFlag(BattleFlag.WildBattle);
            return battle;
        }

        public static Battle StartWildBattle(PokemonParty playerParty, Pokemon pokemon)
        {
            var battle = new Battle(playerParty, new PokemonParty(new List<Pokemon> { pokemon }));
            battle.SetFlag(BattleFlag.WildBattle);
            return battle;
        }

        public static bool SetTerrain(this Battle battle, TerrainEffect effect, int startingTurns)
        {
            if (battle.Terrain != null & !BattleValidation.CanTerrainChanged(battle.Terrain.Effect, effect)) return false;
            battle.Terrain = new Terrain(effect, startingTurns);
            return true;
        }
        public static bool SetWeather(this Battle battle, WeatherCondition condition, int startingTurns)
        {
            if (battle.Weather != null & !BattleValidation.CanWeatherChanged(battle.Weather.Condition, condition)) return false;
            battle.Weather = new Weather(condition, startingTurns);
            return true;
        }

        public static void SetFlag(this Battle battle, BattleFlag flag)
        {
            battle.BattleFlags.Add(flag);
        }

        public static void UseMove(this Battle battle, Pokemon user, Pokemon target, Move move)
        {
            var aiMove = battle.AIChooseMove();
            if (user.IsFaster(target))
            {
                // Player is faster
                var playerDamageAnswer = battle.CalculateDamage(true, move);
                battle.CheckEffects(true, move);
                target.TakeDamage(playerDamageAnswer.Value);
                battle.Log(move, playerDamageAnswer.Value, playerDamageAnswer.AnswerCode == AnswerCodes.Answer_Calculation_CriticalHit, !target.IsAlive);
                if (target.IsAlive)
                {
                    var aiDamageAnswer = battle.CalculateDamage(false, aiMove);
                    battle.CheckEffects(false, aiMove);
                    user.TakeDamage(aiDamageAnswer.Value);
                    battle.Log(aiMove, aiDamageAnswer.Value, aiDamageAnswer.AnswerCode == AnswerCodes.Answer_Calculation_CriticalHit, !user.IsAlive);
                }
            }
            else
            {
                // AI is faster
                var aiDamageAnswer = battle.CalculateDamage(false, aiMove);
                battle.CheckEffects(false, aiMove);
                user.TakeDamage(aiDamageAnswer.Value);
                battle.Log(aiMove, aiDamageAnswer.Value, aiDamageAnswer.AnswerCode == AnswerCodes.Answer_Calculation_CriticalHit, !user.IsAlive);
                if (user.IsAlive)
                {
                    var playerDamageAnswer = battle.CalculateDamage(true, move);
                    battle.CheckEffects(true, move);
                    target.TakeDamage(playerDamageAnswer.Value);
                    battle.Log(move, playerDamageAnswer.Value, playerDamageAnswer.AnswerCode == AnswerCodes.Answer_Calculation_CriticalHit, !target.IsAlive);
                }
            }
            battle.Turn++;
        }
    }
}
