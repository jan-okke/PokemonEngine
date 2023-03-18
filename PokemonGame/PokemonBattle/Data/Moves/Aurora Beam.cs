using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Aurorabeam : Move
	{
		public override string Name => "Aurora Beam";
		public override string Description => "The target is hit with a rainbow-colored beam. This may also lower the target's Attack stat.";
		public override int BasePower => 65;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Ice;
		public Aurorabeam()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}