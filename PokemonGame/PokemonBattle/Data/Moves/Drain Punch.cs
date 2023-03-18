using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Drainpunch : Move
	{
		public override string Name => "Drain Punch";
		public override string Description => "An energy-draining punch. The user's HP is restored by half the damage taken by the target.";
		public override int BasePower => 75;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public Drainpunch()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}