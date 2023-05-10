using PokemonGame.PokemonBattle.Entities;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Defeatist : Ability
{
	public override string Name => "Defeatist";
	public override string Description => "Lowers stats when HP becomes half or less.";
}