using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Thunderbolt : Move
	{
		public override string Name => "Thunderbolt";
		public override string Description => "A strong electric blast is loosed at the target. It may also leave the target with paralysis.";
		public override int BasePower => 90;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 10;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Electric;
		public override bool IgnoresProtect => false;
		public Thunderbolt()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}