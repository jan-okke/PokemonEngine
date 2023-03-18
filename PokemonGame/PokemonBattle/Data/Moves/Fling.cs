using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Fling : Move
	{
		public override string Name => "Fling";
		public override string Description => "The user flings its held item at the target to attack. Its power and effects depend on the item.";
		public override int BasePower => 1;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Dark;
		public override bool IgnoresProtect => false;
		public Fling()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}