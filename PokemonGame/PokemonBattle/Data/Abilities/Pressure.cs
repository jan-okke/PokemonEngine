using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Pressure : Ability
	{
		public override string Name => "Pressure";
		public override string Description => "The Pokémon raises the foe's PP usage.";
	}
}