using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Entities;

public class BattleLog
{
    public List<BattleData> Data { get; }

    public BattleLog()
    {
        Data = new List<BattleData>();
    }
}