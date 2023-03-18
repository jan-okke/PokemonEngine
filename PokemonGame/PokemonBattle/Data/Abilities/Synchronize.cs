using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Synchronize : Ability
	{
		public override string Name => "Synchronize";
		public override string Description => "Passes a burn, poison, or paralysis to the foe.";
	}
}