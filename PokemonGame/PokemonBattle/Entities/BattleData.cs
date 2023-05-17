using System.Collections.Generic;
using PokemonGame.PokemonBattle.Extensions;

namespace PokemonGame.PokemonBattle.Entities;

public class BattleData
{
    public int Turn { get; }
    public Move Move { get; }
    public bool IsPlayerTurn { get; }

    public BattleData(int turn, Move move, bool isPlayerTurn)
    {
        Turn = turn;
        Move = move;
        IsPlayerTurn = isPlayerTurn;
    }
}