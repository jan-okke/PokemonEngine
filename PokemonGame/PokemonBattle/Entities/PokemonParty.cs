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

    public PokemonParty(List<Pokemon> pokemons)
    {
        Pokemons = pokemons;
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

    bool IPokemonParty.IsAlive()
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

        return currentBattlers.Where(p => !object.ReferenceEquals(p, source)).ToList();
    }
}