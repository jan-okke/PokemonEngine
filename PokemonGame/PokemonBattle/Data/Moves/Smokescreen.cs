using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Smokescreen : Move
	{
		public override string Name => "Smokescreen";
		public override string Description => "The user releases an obscuring cloud of smoke or ink. It reduces the target's accuracy.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IgnoresProtect => false;
		public Smokescreen()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}