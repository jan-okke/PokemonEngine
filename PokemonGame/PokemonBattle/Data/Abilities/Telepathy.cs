using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Telepathy : Ability
	{
		public override string Name => "Telepathy";
		public override string Description => "Anticipates an ally's attack and dodges it.";
	}
}