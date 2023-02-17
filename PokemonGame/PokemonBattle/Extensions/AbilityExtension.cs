using PokemonGame.PokemonBattle.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Extensions
{
    public static class AbilityExtension
    {
        public static bool HasName(this Ability ability, string name) => ability.Name == name;

        public static bool HasName(this Ability ability, params string[] names) => names.Any(name => ability.HasName(name));

        public static bool IgnoresOtherAbilities(this Ability ability)
        {
            // TODO: Sunsteel Strike and Searing Sunraze ignore abilities too!
            // https://bulbapedia.bulbagarden.net/wiki/Ignoring_Abilities
            return ability.HasName("Mold Breaker", "Turboblaze", "Teravolt");
        }
    }
}
