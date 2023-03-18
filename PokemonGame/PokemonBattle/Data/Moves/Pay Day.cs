using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Payday : Move
	{
		public override string Name => "Pay Day";
		public override string Description => "Numerous coins are hurled at the target to inflict damage. Money is earned after battle.";
		public override int BasePower => 40;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IgnoresProtect => false;
		public Payday()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}