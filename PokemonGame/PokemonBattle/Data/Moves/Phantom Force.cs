using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Phantomforce : Move
	{
		public override string Name => "Phantom Force";
		public override string Description => "The user vanishes somewhere, then strikes on the next turn. Hits through protections.";
		public override int BasePower => 90;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ghost;
		public Phantomforce()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}