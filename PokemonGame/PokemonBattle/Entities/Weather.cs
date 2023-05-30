using System;
using System.Linq;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Entities;

public class Weather
{
    public event OnWeatherEnd? OnWeatherEnd;
    public event OnWeatherCreate? OnWeatherCreate;
    
    public WeatherCondition Condition { get; }
    private int Turns { get; set; }

    public bool Active => Turns > 0;

    public Weather(WeatherCondition condition, int startingTurns)
    {
        Condition = condition;
        Turns = startingTurns;
        OnWeatherCreate?.Invoke(this, new OnWeatherCreateArgs());
    }

    public bool IsConditionActive(WeatherCondition condition)
    {
        return Turns > 0 && Condition == condition;
    }
    public bool IsConditionActive(params WeatherCondition[] conditions)
    {
        return conditions.Any(IsConditionActive);
    }

    private void OnTurnEnd()
    {
        Console.WriteLine("Yo a weather turn ended lol");
        Turns--;
        if (Turns == 0)
        {
            OnWeatherEnd?.Invoke(this, new OnWeatherEndArgs());
        }
    }

    public void HandleOnTurnEnd(object sender, TurnEndEventHandlerArgs e)
    {
        OnTurnEnd();
    }
}