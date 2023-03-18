using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Damp : Ability
	{
		public override string Name => "Damp";
		public override string Description => "Prevents the use of self-destructing moves.";
	}
}