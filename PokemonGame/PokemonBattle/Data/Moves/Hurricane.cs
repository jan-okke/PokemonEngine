using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Hurricane : Move
	{
		public override string Name => "Hurricane";
		public override string Description => "The user wraps its foe in a fierce wind that flies up into the sky. It may also confuse the foe.";
		public override int BasePower => 110;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 70;
		public override int EffectChance => 30;
		public override MoveTarget Target => MoveTarget.Other;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Flying;
		public override bool IgnoresProtect => false;
		public Hurricane()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}