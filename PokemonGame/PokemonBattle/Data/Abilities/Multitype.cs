using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Multitype : Ability
	{
		public override string Name => "Multitype";
		public override string Description => "Changes type to match the held Plate.";
	}
}