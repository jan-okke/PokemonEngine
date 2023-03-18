using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Pinmissile : Move
	{
		public override string Name => "Pin Missile";
		public override string Description => "Sharp spikes are shot at the target in rapid succession. They hit two to five times in a row.";
		public override int BasePower => 25;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Bug;
		public override bool IgnoresProtect => false;
		public Pinmissile()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}