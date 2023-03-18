using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Waterabsorb : Ability
	{
		public override string Name => "Water Absorb";
		public override string Description => "Restores HP if hit by a Water-type move.";
	}
}