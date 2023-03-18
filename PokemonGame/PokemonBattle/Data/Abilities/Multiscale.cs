using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Multiscale : Ability
	{
		public override string Name => "Multiscale";
		public override string Description => "Reduces damage when HP is full.";
	}
}