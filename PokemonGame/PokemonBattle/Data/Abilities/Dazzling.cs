using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Dazzling : Ability
	{
		public override string Name => "Dazzling";
		public override string Description => "Makes foes unable to use priority attacks.";
	}
}