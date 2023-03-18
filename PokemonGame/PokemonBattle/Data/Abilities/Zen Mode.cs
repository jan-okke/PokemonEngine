using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Zenmode : Ability
	{
		public override string Name => "Zen Mode";
		public override string Description => "Changes the Pokémon's shape when HP is halved.";
	}
}