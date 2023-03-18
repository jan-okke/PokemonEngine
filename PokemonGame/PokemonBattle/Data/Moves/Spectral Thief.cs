using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Spectralthief : Move
	{
		public override string Name => "Spectral Thief";
		public override string Description => "The user hides in the target's shadow, steals the target's stat boosts, and then attacks.";
		public override int BasePower => 90;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ghost;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public override bool CanMetronome => false;
		public Spectralthief()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}