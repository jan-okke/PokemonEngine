using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Leafblade : Move
	{
		public override string Name => "Leaf Blade";
		public override string Description => "The user handles a sharp leaf like a sword and attacks by slashing. It has a high critical-hit ratio.";
		public override int BasePower => 90;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Grass;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public override bool HasHighCriticalHitRate => true;
		public Leafblade()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}