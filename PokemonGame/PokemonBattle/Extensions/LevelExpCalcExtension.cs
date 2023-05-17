using PokemonGame.PokemonBattle.Enums;

using System;

namespace PokemonGame.PokemonBattle.Extensions;

public static class LevelExpCalcExtension
{
    public static int AsLevel(this int experience, ExperienceGroup expGroup) => expGroup switch {
        ExperienceGroup.Normal => (int)Math.Pow(experience, 1.0 / 3),
        ExperienceGroup.Slow => (int)Math.Pow(experience * 0.8, 1.0 / 3), // TODO idk if this works.
        ExperienceGroup.Medium => throw new NotImplementedException(),
        ExperienceGroup.Parabolic => throw new NotImplementedException(),
        ExperienceGroup.Fast => throw new NotImplementedException(),
        ExperienceGroup.Erratic => throw new NotImplementedException(),
        ExperienceGroup.Fluctuating => throw new NotImplementedException(),
        _ => throw new NotImplementedException()
    };

    public static int AsExperience(this int level, ExperienceGroup expGroup) => expGroup switch {
        ExperienceGroup.Normal => (int)Math.Pow(level, 3),
        ExperienceGroup.Slow => (int)(Math.Pow(level * 5, 3) / 4),
        ExperienceGroup.Medium => throw new NotImplementedException(),
        ExperienceGroup.Parabolic => throw new NotImplementedException(),
        ExperienceGroup.Fast => throw new NotImplementedException(),
        ExperienceGroup.Erratic => throw new NotImplementedException(),
        ExperienceGroup.Fluctuating => throw new NotImplementedException(),
        _ => throw new NotImplementedException()
    };
}