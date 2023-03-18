using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Blueflare : Move
	{
		public override string Name => "Blue Flare";
		public override string Description => "The user attacks by engulfing the foe in a beautiful, yet intense, blue flame. It may also burn the foe.";
		public override int BasePower => 130;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override int Accuracy => 85;
		public override int EffectChance => 20;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Fire;
		public override bool IgnoresProtect => false;
		public Blueflare()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}