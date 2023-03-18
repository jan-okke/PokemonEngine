using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Rivalry : Ability
	{
		public override string Name => "Rivalry";
		public override string Description => "Deals more damage to a foe of the same gender.";
	}
}