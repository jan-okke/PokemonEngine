using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Quickguard : Move
	{
		public override string Name => "Quick Guard";
		public override string Description => "The user protects itself and its allies from priority moves. If may fail if used in succession.";
		public override int BasePower => 0;
		public override int PowerPoints => 15;
		public override int Priority => 3;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Fighting;
		public Quickguard()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}