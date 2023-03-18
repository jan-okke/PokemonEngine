using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Unaware : Ability
	{
		public override string Name => "Unaware";
		public override string Description => "Ignores any stat changes in the Pokémon.";
	}
}