using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Anchorshot : Move
	{
		public override string Name => "Anchor Shot";
		public override string Description => "The user entangles the target with its anchor chain. The target becomes unable to flee.";
		public override int BasePower => 80;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 100;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Steel;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Anchorshot()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}