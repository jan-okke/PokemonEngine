using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Weakarmor : Ability
	{
		public override string Name => "Weak Armor";
		public override string Description => "Physical attacks lower Defense and raise Speed.";
	}
}