using PokemonGame.PokemonBattle.Entities;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Competitive : Ability
{
	public override string Name => "Competitive";
	public override string Description => "Sharply boosts Sp. Atk when a stat is lowered.";
}