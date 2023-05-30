using System;

namespace PokemonGame.PokemonBattle.Entities;

public class OnGainExpArgs : EventArgs
{
    public int Amount { get; }
    public OnGainExpArgs(int amount)
    {
        Amount = amount;
    }
}