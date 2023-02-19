using PokemonGame.PokemonBattle.Actions;
using PokemonGame.PokemonBattle.Enums;
using PokemonGame.PokemonBattle.Extensions;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Entities
{
    public class Battle
    {
        public PokemonParty PlayerParty { get; }
        public PokemonParty EnemyParty { get; }
        public BattlerSide PlayerSide { get; }
        public BattlerSide EnemySide { get; }
        public Weather Weather { get; set; }
        public Terrain Terrain { get; set; }
        public Gravity Gravity { get; set; }
        public List<FieldEffect> FieldEffects { get; }
        public List<BattleFlag> BattleFlags { get; }


        public BattleLog Log { get; }
        public BattleType BattleType { get; }
        public int Turn { get; set; }
        public bool IsOngoing => PlayerParty.IsAlive && EnemyParty.IsAlive;

        // TODO this is only for single battle
        public List<Pokemon> ActiveBattlers => new() { PlayerParty.GetFirstAlivePokemon(), EnemyParty.GetFirstAlivePokemon() };

        public Battle(PokemonParty playerParty, PokemonParty enemyParty, Weather weather = null, Terrain terrain = null)
        {
            PlayerParty = playerParty;
            EnemyParty = enemyParty;
            if (weather != null) 
                this.SetWeather(weather.Condition, weather.Turns);
            else 
                Weather = new Weather(WeatherCondition.None, -1);
            if (terrain != null) 
                this.SetTerrain(terrain.Effect, terrain.Turns);
            else 
                Terrain = new Terrain(TerrainEffect.None, -1);
            
            PlayerSide = new BattlerSide();
            EnemySide = new BattlerSide();
            FieldEffects = new List<FieldEffect>();
            BattleFlags = new List<BattleFlag>();
            Log = new BattleLog();
            Gravity = null;
            Turn = 0;
        }
        
    }
}