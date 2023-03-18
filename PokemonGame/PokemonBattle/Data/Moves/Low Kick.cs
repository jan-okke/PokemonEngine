using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Lowkick : Move
	{
		public override string Name => "Low Kick";
		public override string Description => "A powerful low kick that makes the foe fall over. It inflicts greater damage on heavier foes.";
		public override int BasePower => 1;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Lowkick()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}