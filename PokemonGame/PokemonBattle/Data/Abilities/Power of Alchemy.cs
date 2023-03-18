using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Powerofalchemy : Ability
	{
		public override string Name => "Power of Alchemy";
		public override string Description => "Copies the Ability of a defeated ally.";
	}
}