using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Dragonrage : Move
	{
		public override string Name => "Dragon Rage";
		public override string Description => "This attack hits the target with a shock wave of pure rage. This attack always inflicts 40 HP damage.";
		public override int BasePower => 1;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Dragon;
		public override bool IgnoresProtect => false;
		public Dragonrage()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}