using PokemonGame.PokemonBattle.Entities;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Healer : Ability
{
	public override string Name => "Healer";
	public override string Description => "May heal an ally's status conditions.";
}