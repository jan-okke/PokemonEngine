using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Focusblast : Move
	{
		public override string Name => "Focus Blast";
		public override string Description => "The user heightens its mental focus and unleashes its power. It may also lower the target's Sp. Def.";
		public override int BasePower => 120;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override int Accuracy => 70;
		public override int EffectChance => 10;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Fighting;
		public override bool IgnoresProtect => false;
		public override bool IsBombMove => true;
		public Focusblast()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}