using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Wrap : Move
	{
		public override string Name => "Wrap";
		public override string Description => "A long body or vines are used to wrap and squeeze the target for four to five turns.";
		public override int BasePower => 15;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override int Accuracy => 90;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Wrap()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}