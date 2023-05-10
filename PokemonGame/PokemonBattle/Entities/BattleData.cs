using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Entities;

public class BattleData
{
    public Dictionary<string, object> Data { get; }

    public BattleData()
    {
        Data = new Dictionary<string, object>();
    }
}