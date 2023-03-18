using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Mimicry : Ability
	{
		public override string Name => "Mimicry";
		public override string Description => "Changes type depending on the terrain.";
	}
}