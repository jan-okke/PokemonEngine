using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Acrobatics : Move
	{
		public override string Name => "Acrobatics";
		public override string Description => "The user nimbly strikes the foe. This attack does more damage if the user is not holding an item.";
		public override int BasePower => 55;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.Other;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Flying;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Acrobatics()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}