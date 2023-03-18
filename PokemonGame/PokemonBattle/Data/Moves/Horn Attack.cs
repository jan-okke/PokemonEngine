using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Hornattack : Move
	{
		public override string Name => "Horn Attack";
		public override string Description => "The target is jabbed with a sharply pointed horn to inflict damage.";
		public override int BasePower => 65;
		public override int PowerPoints => 25;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Hornattack()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}