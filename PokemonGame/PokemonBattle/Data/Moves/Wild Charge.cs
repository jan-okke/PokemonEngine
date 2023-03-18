using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Wildcharge : Move
	{
		public override string Name => "Wild Charge";
		public override string Description => "The user shrouds itself in electricity and smashes into its foe. It also damages the user a little.";
		public override int BasePower => 90;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Electric;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Wildcharge()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}