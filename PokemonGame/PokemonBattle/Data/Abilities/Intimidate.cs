using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Intimidate : Ability
	{
		public override string Name => "Intimidate";
		public override string Description => "Lowers the foe's Attack stat.";
	}
}