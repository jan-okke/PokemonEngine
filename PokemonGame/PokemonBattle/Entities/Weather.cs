using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Entities
{
    public class Weather
    {
        public WeatherCondition Condition { get; }
        public int Turns { get; internal set; }

        public bool Active => Turns > 0;

        public Weather(WeatherCondition condition, int startingTurns)
        {
            Condition = condition;
            Turns = startingTurns;
        }
    }
}