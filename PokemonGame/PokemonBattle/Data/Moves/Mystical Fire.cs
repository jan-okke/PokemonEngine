using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Mysticalfire : Move
	{
		public override string Name => "Mystical Fire";
		public override string Description => "The user attacks by breathing a special, hot fire. This also lowers the target's Sp. Atk stat.";
		public override int BasePower => 75;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 100;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Fire;
		public override bool IgnoresProtect => false;
		public Mysticalfire()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}