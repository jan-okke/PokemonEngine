using PokemonGame.PokemonBattle.Entities;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Waterabsorb : Ability
{
	public override string Name => "Water Absorb";
	public override string Description => "Restores HP if hit by a Water-type move.";
}