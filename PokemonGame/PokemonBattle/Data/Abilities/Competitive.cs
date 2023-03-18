using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Competitive : Ability
	{
		public override string Name => "Competitive";
		public override string Description => "Sharply boosts Sp. Atk when a stat is lowered.";
	}
}