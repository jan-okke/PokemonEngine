using PokemonGame.PokemonBattle.Entities;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Berserk : Ability
{
	public override string Name => "Berserk";
	public override string Description => "Ups Sp. Atk if a hit makes its HP half or less.";
}