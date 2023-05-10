using PokemonGame.PokemonBattle.Entities;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Minus : Ability
{
	public override string Name => "Minus";
	public override string Description => "Ups Sp. Atk if another Pokémon has Plus or Minus.";
}