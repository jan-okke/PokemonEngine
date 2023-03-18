using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Coreenforcer : Move
	{
		public override string Name => "Core Enforcer";
		public override string Description => "If the target has already moved this turn, the effect of its Ability is negated.";
		public override int BasePower => 100;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.AllNearFoes;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Dragon;
		public override bool IgnoresProtect => false;
		public Coreenforcer()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}