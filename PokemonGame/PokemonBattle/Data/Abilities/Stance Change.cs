using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Stancechange : Ability
	{
		public override string Name => "Stance Change";
		public override string Description => "Changes between Blade and Shield Forme with attacks.";
	}
}