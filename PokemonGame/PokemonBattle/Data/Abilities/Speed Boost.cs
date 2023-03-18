using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Speedboost : Ability
	{
		public override string Name => "Speed Boost";
		public override string Description => "Its Speed stat is gradually boosted.";
	}
}