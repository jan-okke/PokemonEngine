using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Moxie : Ability
	{
		public override string Name => "Moxie";
		public override string Description => "Boosts Attack after knocking out any Pokémon.";
	}
}