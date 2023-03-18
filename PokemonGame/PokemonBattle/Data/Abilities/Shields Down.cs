using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Shieldsdown : Ability
	{
		public override string Name => "Shields Down";
		public override string Description => "Its shell breaks if its HP becomes half or less.";
	}
}