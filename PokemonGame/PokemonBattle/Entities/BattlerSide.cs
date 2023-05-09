using PokemonGame.PokemonBattle.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Entities;

public class BattlerSide
{
    public List<Hazard> Hazards { get; }
    public List<BattlerSideBuff> Buffs { get; }

    public BattlerSide() 
    {
        Hazards = new List<Hazard>();
        Buffs = new List<BattlerSideBuff>();
    }
}