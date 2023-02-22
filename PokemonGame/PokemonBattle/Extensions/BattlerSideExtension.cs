﻿using PokemonGame.PokemonBattle.Entities;
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

        public static bool HasHazard(this BattlerSide side, Hazard hazard) => side.Hazards.Contains(hazard);

        public static bool HasHazard(this BattlerSide side, params Hazard[] hazards) => hazards.Any(h => side.HasHazard(h));

        // TODO there was a more performant way of doing this. (Visual Studio > Code)
        public static int GetHazardCount(this BattlerSide side, Hazard hazard) => side.Hazards.Where(h => h == hazard).Count();

        public static int GetHazardCount(this BattlerSide side, params Hazard[] hazards) => hazards.Aggregate(0, (result, hazard) => result += side.GetHazardCount(hazard));
    }
}
