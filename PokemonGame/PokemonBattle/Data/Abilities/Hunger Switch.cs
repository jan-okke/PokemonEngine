using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities
{
	public class Hungerswitch : Ability
	{
		public override string Name => "Hunger Switch";
		public override string Description => "Changes between Full Belly and Hangry Mode each turn.";
	}
}