using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;
using System.Linq;

namespace PokemonGame.PokemonBattle.Entities;

public class BattlerSide
{
    private List<Hazard> Hazards { get; }
    private List<BattlerSideBuff> Buffs { get; }

    public BattlerSide() 
    {
        Hazards = new List<Hazard>();
        Buffs = new List<BattlerSideBuff>();
    }

    public void GiveBuff(BattlerSideBuff buff)
    {
        Buffs.Add(buff);
    }

    public bool HasBuff(BattlerSideBuff buff)
    {
        return Buffs.Contains(buff);
    }

    public void SwapBuffs(BattlerSide otherSide)
    {
        var otherSideBuffs = Buffs.ToList();
        var thisSideBuffs = otherSide.Buffs.ToList();

        Buffs.Clear();
        otherSide.Buffs.Clear();
        Buffs.AddRange(thisSideBuffs);
        otherSide.Buffs.AddRange(otherSideBuffs);
    }

    public bool HasBuff(params BattlerSideBuff[] buffs)
    {
        return buffs.Any(HasBuff);
    }

    public void AddHazards(Hazard hazard)
    {
        Hazards.Add(hazard);
    }

    public void ClearHazards()
    {
        Hazards.Clear();
    }
}