using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Acupressure : Move
	{
		public override string Name => "Acupressure";
		public override string Description => "The user applies pressure to stress points, sharply boosting one of its stats.";
		public override int BasePower => 0;
		public override int PowerPoints => 30;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.UserOrNearAlly;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Acupressure()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}