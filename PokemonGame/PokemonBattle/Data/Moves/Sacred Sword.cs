using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Sacredsword : Move
	{
		public override string Name => "Sacred Sword";
		public override string Description => "The user attacks by slicing with its long horns. The target's stat changes don't affect the damage.";
		public override int BasePower => 90;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Sacredsword()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}