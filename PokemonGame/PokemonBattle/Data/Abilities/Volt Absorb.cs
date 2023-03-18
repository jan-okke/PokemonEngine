using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Voltabsorb : Ability
	{
		public override string Name => "Volt Absorb";
		public override string Description => "Restores HP if hit by an Electric-type move.";
	}
}