using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Playrough : Move
	{
		public override string Name => "Play Rough";
		public override string Description => "The user plays rough with the target and attacks it. This may also lower the target's Attack stat.";
		public override int BasePower => 90;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fairy;
		public Playrough()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}