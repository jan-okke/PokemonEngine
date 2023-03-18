using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Flamewheel : Move
	{
		public override string Name => "Flame Wheel";
		public override string Description => "The user cloaks itself in fire and charges at the target. It may also leave the target with a burn.";
		public override int BasePower => 60;
		public override int PowerPoints => 25;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 10;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fire;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public override bool ThawsUser => true;
		public Flamewheel()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}