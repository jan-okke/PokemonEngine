using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Pluck : Move
	{
		public override string Name => "Pluck";
		public override string Description => "The user pecks the target. If the target is holding a Berry, the user eats it and gains its effect.";
		public override int BasePower => 60;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.Other;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Flying;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Pluck()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}