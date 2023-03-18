using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Machpunch : Move
	{
		public override string Name => "Mach Punch";
		public override string Description => "The user throws a punch at blinding speed. It is certain to strike first.";
		public override int BasePower => 40;
		public override int PowerPoints => 30;
		public override int Priority => 1;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public Machpunch()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}