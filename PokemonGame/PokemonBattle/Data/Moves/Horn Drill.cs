using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Horndrill : Move
	{
		public override string Name => "Horn Drill";
		public override string Description => "The user stabs the foe with a horn that rotates like a drill. If it hits, the target faints instantly.";
		public override int BasePower => 1;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override int Accuracy => 30;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Horndrill()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}