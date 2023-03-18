using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Yawn : Move
	{
		public override string Name => "Yawn";
		public override string Description => "The user lets loose a huge yawn that lulls the target into falling asleep on the next turn.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IgnoresProtect => false;
		public Yawn()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}