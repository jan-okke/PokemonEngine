using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Superpower : Move
	{
		public override string Name => "Superpower";
		public override string Description => "The user attacks the target with great power. However, it also lowers the user's Attack and Defense.";
		public override int BasePower => 120;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Superpower()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}