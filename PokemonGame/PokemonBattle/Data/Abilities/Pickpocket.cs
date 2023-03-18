using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Pickpocket : Ability
	{
		public override string Name => "Pickpocket";
		public override string Description => "Steals an item when hit by another Pokémon.";
	}
}