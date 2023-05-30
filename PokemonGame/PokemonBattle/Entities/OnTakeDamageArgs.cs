using System;

namespace PokemonGame.PokemonBattle.Entities;

public class OnTakeDamageArgs : EventArgs
{
    public int Amount { get; }
    public Pokemon Dealer { get; }
    public OnTakeDamageArgs(int amount, Pokemon dealer)
    {
        Amount = amount;
        Dealer = dealer;
    }
}