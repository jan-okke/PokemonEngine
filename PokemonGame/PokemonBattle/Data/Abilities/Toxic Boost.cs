using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Toxicboost : Ability
	{
		public override string Name => "Toxic Boost";
		public override string Description => "Powers up physical attacks when poisoned.";
	}
}