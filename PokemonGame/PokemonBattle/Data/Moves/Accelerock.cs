using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Accelerock : Move
	{
		public override string Name => "Accelerock";
		public override string Description => "The user smashes into the target at high speed. This move always goes first.";
		public override int BasePower => 40;
		public override int PowerPoints => 20;
		public override int Priority => 1;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Rock;
		public Accelerock()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}