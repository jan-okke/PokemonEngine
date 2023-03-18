using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Megahorn : Move
	{
		public override string Name => "Megahorn";
		public override string Description => "Using its tough and impressive horn, the user rams into the target with no letup.";
		public override int BasePower => 120;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Bug;
		public Megahorn()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}