using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Gunkshot : Move
	{
		public override string Name => "Gunk Shot";
		public override string Description => "The user shoots filthy garbage at the target to attack. It may also poison the target.";
		public override int BasePower => 120;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Poison;
		public Gunkshot()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}