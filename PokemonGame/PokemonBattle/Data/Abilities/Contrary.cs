using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Contrary : Ability
	{
		public override string Name => "Contrary";
		public override string Description => "Makes stat changes have an opposite effect.";
	}
}