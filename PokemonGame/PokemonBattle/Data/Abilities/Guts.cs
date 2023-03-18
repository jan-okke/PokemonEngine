using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Guts : Ability
	{
		public override string Name => "Guts";
		public override string Description => "Boosts Attack if there is a status problem.";
	}
}