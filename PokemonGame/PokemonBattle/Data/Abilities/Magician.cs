using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Magician : Ability
	{
		public override string Name => "Magician";
		public override string Description => "Steals the held item of a Pokémon it hits.";
	}
}