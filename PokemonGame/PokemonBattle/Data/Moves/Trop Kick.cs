using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Tropkick : Move
	{
		public override string Name => "Trop Kick";
		public override string Description => "The user lands an intense tropical kick on the target. This also lowers the target's Attack stat.";
		public override int BasePower => 70;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Grass;
		public Tropkick()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}