using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Wakeupslap : Move
	{
		public override string Name => "Wake-Up Slap";
		public override string Description => "This attack inflicts big damage on a sleeping target. It also wakes the target up, however.";
		public override int BasePower => 70;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Wakeupslap()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}