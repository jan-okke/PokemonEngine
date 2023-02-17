using PokemonGame.PokemonBattle.Entities;
using System;

namespace PokemonGame.PokemonBattle.Extensions
{
    public static class PokemonPartyExtension
    {
        public static Pokemon GetFirstAlivePokemon(this PokemonParty party)
        {
            if (!party.IsAlive) throw new Exception("Pokemon party not alive!");
            foreach (Pokemon p in party.Pokemons)
            {
                if (p.IsAlive) return p;
            }
            throw new Exception("Party is alive but no Pokemons are.");
        }
    }
}