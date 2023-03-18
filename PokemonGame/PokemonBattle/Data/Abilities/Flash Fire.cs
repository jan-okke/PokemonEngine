using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Flashfire : Ability
	{
		public override string Name => "Flash Fire";
		public override string Description => "It powers up Fire-type moves if it's hit by one.";
	}
}