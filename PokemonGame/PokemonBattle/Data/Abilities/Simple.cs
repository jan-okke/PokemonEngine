using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Simple : Ability
	{
		public override string Name => "Simple";
		public override string Description => "The Pokémon is prone to wild stat changes.";
	}
}