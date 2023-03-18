using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Download : Ability
	{
		public override string Name => "Download";
		public override string Description => "Adjusts power according to a foe's defenses.";
	}
}