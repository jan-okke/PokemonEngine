using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Magicguard : Ability
	{
		public override string Name => "Magic Guard";
		public override string Description => "The Pokémon only takes damage from attacks.";
	}
}