using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Gigaimpact : Move
	{
		public override string Name => "Giga Impact";
		public override string Description => "The user charges at the target using every bit of its power. The user must rest on the next turn.";
		public override int BasePower => 150;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override int Accuracy => 90;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Gigaimpact()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}