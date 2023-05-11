using System;
using System.Collections.Generic;
using System.Linq;
using PokemonGame.PokemonBattle.Enums;
using PokemonGame.PokemonBattle.Exceptions;
using PokemonGame.PokemonBattle.Interfaces;

namespace PokemonGame.PokemonBattle.Entities;

public class PokemonParty : IPokemonParty
{
    private List<Pokemon> Pokemons { get; }
    private int AliveCount => Pokemons.Count(p => p.IsAlive);
    private int PokemonCount => Pokemons.Count;
    public List<Pokemon> ActiveBattlers { get; } = new();

    public PokemonParty(List<Pokemon>? pokemons)
    {
        Pokemons = pokemons ?? new List<Pokemon>();
    }

    public PokemonParty(Pokemon pokemon)
    {
        Pokemons = new List<Pokemon> { pokemon };
    }

    public List<Pokemon> GetPokemons()
    {
        return Pokemons;
    }

    public void AddPokemon(Pokemon pokemon)
    {
        if (PokemonCount == 6)
        {
            throw new PartyFullException();
        }
        Pokemons.Add(pokemon);
    }

    public Pokemon GetFirstAlivePokemon()
    {
        if (AliveCount == 0)
        {
            throw new PartyNotAliveException();
        }

        return Pokemons.First(p => p.IsAlive);
    }

    public bool IsAlive()
    {
        return Pokemons.Any(p => p.IsAlive);
    }

    public int GetFaintedCount()
    {
        return Pokemons.Count(p => !p.IsAlive);
    }

    public List<Pokemon> GetAllies(IBattle battle, Pokemon source)
    {
        if (battle.GetBattleType() == BattleType.SingleBattle)
        {
            throw new ArgumentException(null, nameof(battle));
        }

        var currentBattlers = battle.GetActiveBattlers();

        return currentBattlers.Where(p => !ReferenceEquals(p, source)).ToList();
    }

    public void SendOut(Pokemon pokemon)
    {
        ActiveBattlers.Add(pokemon);
    }

    public void ChangeActiveBattler(Pokemon toSwitchOut, Pokemon replacement)
    {
        ActiveBattlers.Remove(toSwitchOut);
        ActiveBattlers.Add(replacement);
    }
}