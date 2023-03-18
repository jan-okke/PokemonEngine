using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Motordrive : Ability
	{
		public override string Name => "Motor Drive";
		public override string Description => "Raises Speed if hit by an Electric-type move.";
	}
}