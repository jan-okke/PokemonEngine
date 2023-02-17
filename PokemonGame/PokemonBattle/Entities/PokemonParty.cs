using System.Collections.Generic;
using System.Linq;
using PokemonGame.PokemonBattle.Extensions;

namespace PokemonGame.PokemonBattle.Entities
{
    public class PokemonParty
    {
        public List<Pokemon> Pokemons { get; set; }
        public bool IsAlive => Pokemons.Where(p => p.IsAlive).Any();
        public int AliveCount => Pokemons.Where(p => p.IsAlive).Count();
        public int FaintedCount => Pokemons.Where(p => !p.IsAlive).Count();

        public PokemonParty(List<Pokemon> pokemons)
        {
            Pokemons = pokemons;
        }
    }
}