using PokemonGame.PokemonBattle.Entities;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Regenerator : Ability
{
	public override string Name => "Regenerator";
	public override string Description => "Restores a little HP when withdrawn from battle.";
}