using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Darkestlariat : Move
	{
		public override string Name => "Darkest Lariat";
		public override string Description => "The user swings both arms and hits the target. Ignores the target's stat changes.";
		public override int BasePower => 85;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Dark;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Darkestlariat()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}