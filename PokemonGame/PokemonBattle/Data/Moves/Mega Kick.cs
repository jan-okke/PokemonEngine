using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Megakick : Move
	{
		public override string Name => "Mega Kick";
		public override string Description => "The target is attacked by a kick launched with muscle-packed power.";
		public override int BasePower => 120;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override int Accuracy => 75;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Megakick()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}