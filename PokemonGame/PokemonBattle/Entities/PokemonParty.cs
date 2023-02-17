using System.Collections.Generic;
using System.Linq;
using PokemonGame.PokemonBattle.Extensions;

namespace PokemonGame.PokemonBattle.Entities
{
    public class PokemonParty
    {
        public List<Pokemon> Pokemons { get; set; }
        public bool IsAlive => Pokemons.Where(p => p.IsAlive()).Count() > 0;
    }
}