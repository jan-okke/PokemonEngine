using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Armthrust : Move
	{
		public override string Name => "Arm Thrust";
		public override string Description => "The user looses a flurry of open-palmed arm thrusts that hit two to five times in a row.";
		public override int BasePower => 15;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Armthrust()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}