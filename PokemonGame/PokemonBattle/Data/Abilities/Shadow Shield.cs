using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Shadowshield : Ability
	{
		public override string Name => "Shadow Shield";
		public override string Description => "Resists damage while its HP is full.";
	}
}