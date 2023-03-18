using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Risingvoltage : Move
	{
		public override string Name => "Rising Voltage";
		public override string Description => "The user attacks with electric voltage rising from the ground. Power is doubled on Electric Terrain.";
		public override int BasePower => 70;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Electric;
		public Risingvoltage()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}