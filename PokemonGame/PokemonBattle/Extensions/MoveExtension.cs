using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Extensions;

public static class MoveExtension
{
    public static Stat GetTargetDefense(this Move move)
    {
        if (move.NameIsAnyOf("Psyshock"))
        {
            return Stat.Defense;
        }

        return move.Category switch
        {
            MoveCategory.Physical => Stat.Defense,
            MoveCategory.Special => Stat.SpecialDefense,
            MoveCategory.Status => throw new ArgumentException(null, nameof(move)),
            _ => throw new NotImplementedException(),
        };
    }
    public static bool BasePowerBelow(this Move move, int amount) => move.BasePower < amount;
        
    public static bool HasType(this Move move, PokemonType type) => move.Type == type;

    public static bool HasType(this Move move, params PokemonType[] types) => types.Any(t => move.HasType(t));

    public static bool NameIsAnyOf(this Move move, params string[] names) => names.Any(n => move.Name == n);

    public static int GetTargetCount(this Move move, Battle battle) => 1; // TODO

    public static bool IsFixedRandom(this Move move)
    {
        return move.Name == "Spit Up";
    }
    public static bool IsAffectedByBurn(this Move move) => move.IsPhysical && move.Name != "Facade";
        
    public static double GetBurnMod(this Move move) => IsAffectedByBurn(move) ? 0.5 : throw new Exception("Attempted to get Burn Mod without checking if affected by burn.");

    public static bool PowerPointsAbove(this Move move, int amount) => move.PowerPoints > amount;
}