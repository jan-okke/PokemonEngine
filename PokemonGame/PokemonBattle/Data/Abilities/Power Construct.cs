using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Powerconstruct : Ability
	{
		public override string Name => "Power Construct";
		public override string Description => "Changes with other Cells if HP becomes half or less.";
	}
}