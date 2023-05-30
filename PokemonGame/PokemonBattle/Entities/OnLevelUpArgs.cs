using System;

namespace PokemonGame.PokemonBattle.Entities;

public class OnLevelUpArgs : EventArgs
{
    public int OldLevel { get; }
    public int NewLevel { get; }
    public OnLevelUpArgs(int oldLevel, int newLevel)
    {
        OldLevel = oldLevel;
        NewLevel = newLevel;
    }
}