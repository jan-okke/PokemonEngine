using PokemonGame.PokemonBattle.Entities;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Beastboost : Ability
{
	public override string Name => "Beast Boost";
	public override string Description => "Boosts its best stat each time it deals a KO.";
}