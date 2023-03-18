using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Bonerush : Move
	{
		public override string Name => "Bone Rush";
		public override string Description => "The user strikes the target with a hard bone two to five times in a row.";
		public override int BasePower => 25;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 90;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ground;
		public override bool IgnoresProtect => false;
		public Bonerush()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}