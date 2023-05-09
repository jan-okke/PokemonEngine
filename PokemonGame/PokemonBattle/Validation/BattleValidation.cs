using PokemonGame.PokemonBattle.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Validation;

public abstract class BattleValidation
{
    public static bool CanWeatherChanged(WeatherCondition oldCondition, WeatherCondition newCondition)
    {
        return true; // TODO
    }
    public static bool CanTerrainChanged(TerrainEffect oldEffect, TerrainEffect newEffect)
    {
        return true; // Placeholder, there are no conditions that permit that, but in case something has to be added later.
    }
}