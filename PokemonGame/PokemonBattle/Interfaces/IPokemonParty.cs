using System.Collections.Generic;
using PokemonGame.PokemonBattle.Entities;

namespace PokemonGame.PokemonBattle.Interfaces;

public interface IPokemonParty
{
    List<Pokemon> GetPokemons();
    void AddPokemon(Pokemon pokemon);
    Pokemon GetFirstAlivePokemon();
    bool IsAlive();
    int GetFaintedCount();
    List<Pokemon> GetAllies(IBattle battle, Pokemon source);
}