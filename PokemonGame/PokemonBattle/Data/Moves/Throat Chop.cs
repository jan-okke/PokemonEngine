using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Throatchop : Move
	{
		public override string Name => "Throat Chop";
		public override string Description => "The user attacks the target's throat. The target cannot use sound-based moves for two turns.";
		public override int BasePower => 80;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 100;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Dark;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Throatchop()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}