using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Validation
{
    public static class PokemonValidation
    {
        public static bool CanFlinch(this Pokemon pokemon) => true; // TODO

        public static bool CanTrap(this Pokemon pokemon) => true; // TODO

        public static bool CanConfused(this Pokemon pokemon) => true; // TODO

        public static bool CanMute(this Pokemon pokemon) => true; // TODO
        
        public static bool CanGetStatusCondition(this Pokemon pokemon, StatusConditionType condition) => true; // TODO

        public static bool CanDynamax(this Pokemon pokemon) => false; // TODO
    }
}
