using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Focuspunch : Move
	{
		public override string Name => "Focus Punch";
		public override string Description => "The user focuses its mind before launching a punch. It will fail if the user is hit before it is used.";
		public override int BasePower => 150;
		public override int PowerPoints => 20;
		public override int Priority => -3;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public Focuspunch()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}