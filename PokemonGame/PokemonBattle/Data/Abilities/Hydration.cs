using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Hydration : Ability
	{
		public override string Name => "Hydration";
		public override string Description => "Heals status problems if it is raining.";
	}
}