using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Surgingstrikes : Move
	{
		public override string Name => "Surging Strikes";
		public override string Description => "Hits three times in a row with mastery of the Water style. This attack always deals critical hits.";
		public override int BasePower => 25;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Water;
		public Surgingstrikes()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}