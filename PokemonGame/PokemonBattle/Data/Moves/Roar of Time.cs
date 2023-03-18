using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Roaroftime : Move
	{
		public override string Name => "Roar of Time";
		public override string Description => "The user blasts the target with power that distorts even time. The user must rest on the next turn.";
		public override int BasePower => 150;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Dragon;
		public Roaroftime()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}