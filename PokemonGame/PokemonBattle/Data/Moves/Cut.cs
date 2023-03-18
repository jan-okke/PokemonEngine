using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Cut : Move
	{
		public override string Name => "Cut";
		public override string Description => "The target is cut with a scythe or a claw. It can also be used to cut down thin trees.";
		public override int BasePower => 50;
		public override int PowerPoints => 30;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Cut()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}