using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Extensions
{
    public static class BattlerSideExtension
    {
        public static bool HasBuff(this BattlerSide side, BattlerSideBuff buff) => side.Buffs.Contains(buff);

        public static bool HasBuff(this BattlerSide side, params BattlerSideBuff[] buffs) => buffs.Any(b => side.HasBuff(b));
    }
}
