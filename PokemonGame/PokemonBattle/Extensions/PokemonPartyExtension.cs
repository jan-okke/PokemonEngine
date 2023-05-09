using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using PokemonGame.PokemonBattle.Interfaces;

namespace PokemonGame.PokemonBattle.Extensions;

public static class PokemonPartyExtension
{
    /*
    public static Pokemon GetFirstAlivePokemon(this IPokemonParty party)
    {
        if (!party.IsAlive()) throw new PartyNotAliveException();
        foreach (var p in party.GetPokemons().Where(p => p.IsAlive))
        {
            return p;
        }
        throw new PartyNotAliveException();
    }

    public static List<Pokemon> GetFirstAlivePokemons(this IPokemonParty party, int amount)
    {
        if (!party.IsAlive()) throw new PartyNotAliveException();
        if (amount == 1) return new List<Pokemon>() { party.GetFirstAlivePokemon() };

        var result = new List<Pokemon>();

        foreach (var p in party.GetPokemons())
        {
            if (p.IsAlive) result.Add(p);
            if (result.Count == amount) return result;
        }
        throw new Exception($"Not enough alive Pokemons found! Requested: {amount}");
    }

    public static List<Pokemon> GetAllies(this PokemonParty party, Battle battle, Pokemon sender)
    {
        
    }

    public static void AddPokemon(this IPokemonParty party, Pokemon p)
    {
        party.AddPokemon(p);
    }
    */
}