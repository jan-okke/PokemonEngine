using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Analytic : Ability
	{
		public override string Name => "Analytic";
		public override string Description => "Boosts move power when the Pokémon moves last.";
	}
}