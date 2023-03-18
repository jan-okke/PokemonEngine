using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Soulheart : Ability
	{
		public override string Name => "Soul-Heart";
		public override string Description => "Boosts Sp. Atk each time a Pokémon faints.";
	}
}