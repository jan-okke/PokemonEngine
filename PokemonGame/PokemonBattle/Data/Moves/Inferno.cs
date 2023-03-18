using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Inferno : Move
	{
		public override string Name => "Inferno";
		public override string Description => "The user attacks by engulfing the target in an intense fire. It leaves the target with a burn.";
		public override int BasePower => 100;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override int Accuracy => 50;
		public override int EffectChance => 100;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Fire;
		public override bool IgnoresProtect => false;
		public Inferno()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}