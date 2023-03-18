using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Unburden : Ability
	{
		public override string Name => "Unburden";
		public override string Description => "Raises Speed if a held item is used.";
	}
}