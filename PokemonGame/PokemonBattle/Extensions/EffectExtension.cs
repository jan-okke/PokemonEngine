using PokemonGame.PokemonBattle.Enums;
using PokemonGame.PokemonBattle.Entities;
using System.Linq;

namespace PokemonGame.PokemonBattle.Extensions;

public static class EffectExtension
{
    public static bool HasType(this Effect effect, EffectType type) => effect.Type == type;

    public static bool HasType(this Effect effect, params EffectType[] types) => types.Any(t => effect.HasType(t));
}