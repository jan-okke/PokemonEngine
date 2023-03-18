using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Jumpkick : Move
	{
		public override string Name => "Jump Kick";
		public override string Description => "The user jumps up high, then strikes with a kick. If the kick misses, the user hurts itself.";
		public override int BasePower => 100;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 95;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Jumpkick()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}