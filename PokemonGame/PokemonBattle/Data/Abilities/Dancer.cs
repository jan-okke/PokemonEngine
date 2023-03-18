using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Dancer : Ability
	{
		public override string Name => "Dancer";
		public override string Description => "Repeats another Pokémon's dance move immediately.";
	}
}