using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Quickdraw : Ability
	{
		public override string Name => "Quick Draw";
		public override string Description => "Enables the Pokémon to move first occasionally.";
	}
}