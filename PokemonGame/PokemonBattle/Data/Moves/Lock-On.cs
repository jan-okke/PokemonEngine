using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Lockon : Move
	{
		public override string Name => "Lock-On";
		public override string Description => "The user takes sure aim at the target. It ensures the next attack does not fail to hit the target.";
		public override int BasePower => 0;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IgnoresProtect => false;
		public Lockon()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}