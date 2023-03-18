using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Sandattack : Move
	{
		public override string Name => "Sand Attack";
		public override string Description => "Sand is hurled in the target's face, reducing its accuracy.";
		public override int BasePower => 0;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Ground;
		public override bool IgnoresProtect => false;
		public Sandattack()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}