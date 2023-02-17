using PokemonGame.PokemonBattle.Entities;
using System;
using System.Collections.Generic;

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

        public static List<Pokemon> GetFirstAlivePokemons(this PokemonParty party, int amount)
        {
            if (!party.IsAlive) throw new Exception("Pokemon party not alive!");
            if (amount == 1) return new List<Pokemon>() { party.GetFirstAlivePokemon() };

            List<Pokemon> result = new List<Pokemon>();

            foreach (Pokemon p in party.Pokemons)
            {
                if (p.IsAlive) result.Add(p);
                if (result.Count == amount) return result;
            }
            throw new Exception($"Not enough alive Pokemons found! Requested: {amount}");
        }

        public static List<Pokemon> GetAllies(this PokemonParty party, Battle battle, Pokemon sender)
        {
            if (battle.IsSingleBattle()) throw new ArgumentException(null, nameof(battle));
            List<Pokemon> currentBattlers = battle.ActiveBattlers;
            List<Pokemon> result = new List<Pokemon>();

            foreach (Pokemon p in currentBattlers)
            {
                if (p == sender) continue;
                result.Add(p);
            }
            return result;
        }
    }
}