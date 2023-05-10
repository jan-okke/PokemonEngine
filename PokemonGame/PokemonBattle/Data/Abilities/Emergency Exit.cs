using PokemonGame.PokemonBattle.Entities;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Emergencyexit : Ability
{
	public override string Name => "Emergency Exit";
	public override string Description => "Switches out if its HP becomes half or less.";
}