using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Meanlook : Move
	{
		public override string Name => "Mean Look";
		public override string Description => "The user pins the target with a dark, arresting look. The target becomes unable to flee.";
		public override int BasePower => 0;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Meanlook()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}