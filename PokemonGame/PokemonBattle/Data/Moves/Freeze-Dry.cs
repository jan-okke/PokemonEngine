using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Freezedry : Move
	{
		public override string Name => "Freeze-Dry";
		public override string Description => "The user rapidly cools the target. This may freeze the target. Is super-effective on Water types.";
		public override int BasePower => 70;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Ice;
		public Freezedry()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}