using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Skilllink : Ability
	{
		public override string Name => "Skill Link";
		public override string Description => "Increases the frequency of multi-strike moves.";
	}
}