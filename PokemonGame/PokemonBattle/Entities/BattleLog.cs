using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Entities;

public class BattleLog
{
    public List<BattleData> Data { get; }

    public BattleLog()
    {
        Data = new List<BattleData>();
    }
}