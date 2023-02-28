using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
    public class Abomasnow : Pokemon
    {
        public override string Name => "Abomasnow";
        public override Ability Ability => new SnowWarning();
        public override List<PokemonType> Types => new List<PokemonType> { PokemonType.Ice, PokemonType.Grass };
        public override Stats BaseStats => new Stats(90, 92, 75, 92, 85, 60);
        public Abomasnow() {}

        public Abomasnow(int level) { Level = level; }
    }
}
