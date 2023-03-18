using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Gyroball : Move
	{
		public override string Name => "Gyro Ball";
		public override string Description => "The user tackles the target with a high-speed spin. The slower the user, the greater the damage.";
		public override int BasePower => 1;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Steel;
		public Gyroball()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}