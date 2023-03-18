using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Highjumpkick : Move
	{
		public override string Name => "High Jump Kick";
		public override string Description => "The target is attacked with a knee kick from a jump. If it misses, the user is hurt instead.";
		public override int BasePower => 130;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Highjumpkick()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}