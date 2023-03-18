using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Cometpunch : Move
	{
		public override string Name => "Comet Punch";
		public override string Description => "The target is hit with a flurry of punches that strike two to five times in a row.";
		public override int BasePower => 18;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public Cometpunch()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}