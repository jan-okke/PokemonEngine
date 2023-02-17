using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Extensions
{
    public static class MoveExtension
    {
        public static Stat GetTargetDefense(this Move move)
        {
            if (move.Name == "Psyshock") return Stat.Defense;
            return move.Category switch
            {
                MoveCategory.Phsyical => Stat.Defense,
                MoveCategory.Special => Stat.SpecialDefense,
                MoveCategory.Status => throw new ArgumentException(null, nameof(move)),
                _ => throw new NotImplementedException(),
            };
        }

        public static int GetTargetCount(this Move move, Battle battle) => 1; // TODO

        public static bool IsFixedRandom(this Move move)
        {
            return move.Name != "Spit Up";
        }
        public static bool IsAffectedByBurn(this Move move) => move.Category == MoveCategory.Phsyical && move.Name != "Facade";
        
        public static double GetBurnMod(this Move move) => IsAffectedByBurn(move) ? 0.5 : throw new Exception("Attempted to get Burn Mod without checking if affected by burn.");
    }
}
