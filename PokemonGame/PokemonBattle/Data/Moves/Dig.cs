using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Dig : Move
	{
		public override string Name => "Dig";
		public override string Description => "The user burrows, then attacks on the second turn. It can also be used to exit dungeons.";
		public override int BasePower => 80;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ground;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Dig()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}