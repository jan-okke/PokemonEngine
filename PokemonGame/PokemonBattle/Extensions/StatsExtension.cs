using PokemonGame.PokemonBattle.Entities;
using System;

namespace PokemonGame.PokemonBattle.Extensions;

public static class StatsExtension 
{
    public static int Sum(this Stats stats) 
    {
        return stats.HP + stats.Attack + stats.Defense + stats.SpecialAttack + stats.SpecialDefense + stats.Speed;
    }
    public static double Avg(this Stats stats) 
    {
        return stats.Sum() / 6;
    }

    public static double Modify(this int i, int statStage, bool isAccuracyEvasion) => statStage switch {
        -6 => i * (isAccuracyEvasion ? 3.0 / 9 : 2.0 / 8),
        -5 => i * (isAccuracyEvasion ? 3.0 / 8 : 2.0 / 7),
        -4 => i * (isAccuracyEvasion ? 3.0 / 7 : 2.0 / 6),
        -3 => i * (isAccuracyEvasion ? 3.0 / 6 : 2.0 / 5),
        -2 => i * (isAccuracyEvasion ? 3.0 / 5 : 2.0 / 4),
        -1 => i * (isAccuracyEvasion ? 3.0 / 4 : 2.0 / 3),
        -0 => i,
        1 => i * (isAccuracyEvasion ? 4.0 / 3 : 3.0 / 2),
        2 => i * (isAccuracyEvasion ? 5.0 / 3 : 4.0 / 2),
        3 => i * (isAccuracyEvasion ? 6.0 / 3 : 5.0 / 2),
        4 => i * (isAccuracyEvasion ? 7.0 / 3 : 6.0 / 2),
        5 => i * (isAccuracyEvasion ? 8.0 / 3 : 7.0 / 2),
        6 => i * (isAccuracyEvasion ? 9.0 / 3 : 8.0 / 2),
        _ => throw new Exception("Stat stage invalid!")
    };
}