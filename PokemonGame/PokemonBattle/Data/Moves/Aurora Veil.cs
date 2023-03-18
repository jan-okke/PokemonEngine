using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Auroraveil : Move
	{
		public override string Name => "Aurora Veil";
		public override string Description => "This move reduces damage from attacks for five turns. This can be used only in a hailstorm.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.UserSide;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Ice;
		public Auroraveil()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}