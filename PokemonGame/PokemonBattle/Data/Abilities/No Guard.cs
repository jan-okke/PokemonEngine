using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Noguard : Ability
	{
		public override string Name => "No Guard";
		public override string Description => "Ensures attacks by or against the Pokémon land.";
	}
}