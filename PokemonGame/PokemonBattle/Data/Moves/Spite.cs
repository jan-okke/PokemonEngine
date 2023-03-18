using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Spite : Move
	{
		public override string Name => "Spite";
		public override string Description => "The user unleashes its grudge on the move last used by the target by cutting 4 PP from it.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Ghost;
		public override bool IgnoresProtect => false;
		public Spite()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}