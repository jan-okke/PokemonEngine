using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Slowstart : Ability
	{
		public override string Name => "Slow Start";
		public override string Description => "Temporarily halves Attack and Speed.";
	}
}