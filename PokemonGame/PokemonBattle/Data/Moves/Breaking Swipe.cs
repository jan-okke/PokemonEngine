using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Breakingswipe : Move
	{
		public override string Name => "Breaking Swipe";
		public override string Description => "The user swings its tough tail wildly and attacks all foes. This also lowers their Attack stats.";
		public override int BasePower => 60;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Dragon;
		public Breakingswipe()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}