using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Pickup : Ability
	{
		public override string Name => "Pickup";
		public override string Description => "The Pokémon may pick up items.";
	}
}