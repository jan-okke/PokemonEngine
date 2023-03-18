using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Wimpout : Ability
	{
		public override string Name => "Wimp Out";
		public override string Description => "Cowardly switches out if its HP becomes half or less.";
	}
}