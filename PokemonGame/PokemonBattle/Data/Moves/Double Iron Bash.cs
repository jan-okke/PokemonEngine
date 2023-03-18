using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Doubleironbash : Move
	{
		public override string Name => "Double Iron Bash";
		public override string Description => "The user rotates, centering the hex nut in its chest, and then strikes twice. May cause flinching.";
		public override int BasePower => 60;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 30;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Steel;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public override bool IsPunchingMove => true;
		public override bool CanMetronome => false;
		public Doubleironbash()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}