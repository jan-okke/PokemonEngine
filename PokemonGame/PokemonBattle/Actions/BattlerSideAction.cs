using PokemonGame.PokemonBattle.Enums;
using PokemonGame.PokemonBattle.Entities;

namespace PokemonGame.PokemonBattle.Actions
{
    public static class BattleSideAction
    {
        public static void GiveBuff(this BattlerSide side, BattlerSideBuff buff) { side.Buffs.Add(buff); } 
    }
}