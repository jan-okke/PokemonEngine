using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Dryskin : Ability
	{
		public override string Name => "Dry Skin";
		public override string Description => "Reduces HP if it is hot. Water restores HP.";
	}
}