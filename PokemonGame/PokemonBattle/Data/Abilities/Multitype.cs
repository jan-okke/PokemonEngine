using PokemonGame.PokemonBattle.Entities;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Multitype : Ability
{
	public override string Name => "Multitype";
	public override string Description => "Changes type to match the held Plate.";
}