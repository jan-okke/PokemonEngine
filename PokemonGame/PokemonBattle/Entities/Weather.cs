using System.Linq;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Entities;

public class Weather
{
    public WeatherCondition Condition { get; }
    private int Turns { get; set; }

    public bool Active => Turns > 0;

    public Weather(WeatherCondition condition, int startingTurns)
    {
        Condition = condition;
        Turns = startingTurns;
    }

    public bool IsConditionActive(WeatherCondition condition)
    {
        return Turns > 0 && Condition == condition;
    }
    public bool IsConditionActive(params WeatherCondition[] conditions)
    {
        return conditions.Any(IsConditionActive);
    }

    public void OnTurnEnd()
    {
        Turns--;
    }
}