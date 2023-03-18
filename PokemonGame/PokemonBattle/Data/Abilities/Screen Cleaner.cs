using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Screencleaner : Ability
	{
		public override string Name => "Screen Cleaner";
		public override string Description => "On entering battle, clears effects of Reflect, etc.";
	}
}