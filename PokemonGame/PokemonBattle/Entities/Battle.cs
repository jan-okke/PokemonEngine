using PokemonGame.PokemonBattle.Enums;
using PokemonGame.PokemonBattle.Extensions;

namespace PokemonGame.PokemonBattle.Entities
{
    public class Battle
    {
        public PokemonParty PlayerParty { get; }
        public PokemonParty EnemyParty { get; }
        public Weather Weather { get; set; }
        public Terrain Terrain { get; set; }
        public int Turn { get; }
        public bool IsOngoing => PlayerParty.IsAlive && EnemyParty.IsAlive;

        public Battle(PokemonParty playerParty, PokemonParty enemyParty, Weather weather = null, Terrain terrain = null)
        {
            PlayerParty = playerParty;
            EnemyParty = enemyParty;
            if (weather != null) this.SetWeather(weather.Condition, weather.Turns);
            if (terrain != null) this.SetTerrain(terrain.Effect, terrain.Turns);
            Turn = 0;
        }
        
    }
}