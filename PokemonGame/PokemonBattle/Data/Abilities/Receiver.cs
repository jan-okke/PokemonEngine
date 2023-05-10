using PokemonGame.PokemonBattle.Entities;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Receiver : Ability
{
	public override string Name => "Receiver";
	public override string Description => "Copies the Ability of a defeated ally.";
}