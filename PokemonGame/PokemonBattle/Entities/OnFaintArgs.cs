using System;

namespace PokemonGame.PokemonBattle.Entities;

public class OnFaintArgs : EventArgs
{
    public Pokemon Killer { get; }
    public OnFaintArgs(Pokemon killer)
    {
        Killer = killer;
    }
}