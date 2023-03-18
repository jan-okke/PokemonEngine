using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Trace : Ability
	{
		public override string Name => "Trace";
		public override string Description => "The Pokémon copies a foe's Ability.";
	}
}