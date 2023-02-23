using PokemonGame.PokemonBattle.Enums;

using System;

namespace PokemonGame.PokemonBattle.Extensions
{
    public static class LevelExpCalcExtension
    {
        public static int AsLevel(this int i, ExperienceGroup expGroup) => expGroup switch {
            ExperienceGroup.Normal => (int)Math.Pow(i, 1.0 / 3),
            _ => throw new NotImplementedException()
        };

        public static int AsExperience(this int i, ExperienceGroup expGroup) => expGroup switch {
            ExperienceGroup.Normal => (int)Math.Pow(i, 3),
            _ => throw new NotImplementedException()
        };
    }
}