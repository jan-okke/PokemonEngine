using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Vitalthrow : Move
	{
		public override string Name => "Vital Throw";
		public override string Description => "The user attacks last. In return, this throw move is guaranteed not to miss.";
		public override int BasePower => 70;
		public override int PowerPoints => 10;
		public override int Priority => -1;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Vitalthrow()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}