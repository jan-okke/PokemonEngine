using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Defeatist : Ability
	{
		public override string Name => "Defeatist";
		public override string Description => "Lowers stats when HP becomes half or less.";
	}
}