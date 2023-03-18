using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Poisonheal : Ability
	{
		public override string Name => "Poison Heal";
		public override string Description => "Restores HP if the Pokémon is poisoned.";
	}
}