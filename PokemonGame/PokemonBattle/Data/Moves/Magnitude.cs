using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Magnitude : Move
	{
		public override string Name => "Magnitude";
		public override string Description => "The user looses a ground-shaking quake affecting everyone around the user. Its power varies.";
		public override int BasePower => 1;
		public override int PowerPoints => 30;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.AllNearOthers;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ground;
		public override bool IgnoresProtect => false;
		public Magnitude()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}