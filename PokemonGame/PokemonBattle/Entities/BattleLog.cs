using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Entities;

public class BattleLog
{
    public Dictionary<int, List<BattleData>> Data { get; }

    public BattleLog()
    {
        Data = new Dictionary<int, List<BattleData>>();
    }

    public void AddData(int turn, Move move, bool playerTurn)
    {
        if (Data.TryGetValue(turn, out var value))
        {
            value.Add(new BattleData(turn, move, playerTurn));
        }
        else
        {
            Data.Add(turn, new List<BattleData>
            {
                new(turn, move, playerTurn)
            });
        }
    }
}