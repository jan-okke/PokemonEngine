using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Rocktomb : Move
	{
		public override string Name => "Rock Tomb";
		public override string Description => "Boulders are hurled at the target. It also lowers the target's Speed by preventing its movement.";
		public override int BasePower => 60;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Rock;
		public Rocktomb()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}