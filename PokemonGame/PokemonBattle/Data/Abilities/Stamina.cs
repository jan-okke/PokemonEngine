using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Stamina : Ability
	{
		public override string Name => "Stamina";
		public override string Description => "Boosts Defense when hit by an attack.";
	}
}