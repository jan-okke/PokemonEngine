using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Scrappy : Ability
	{
		public override string Name => "Scrappy";
		public override string Description => "Enables moves to hit Ghost-type Pokémon.";
	}
}