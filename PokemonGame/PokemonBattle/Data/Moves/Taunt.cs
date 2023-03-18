using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Taunt : Move
	{
		public override string Name => "Taunt";
		public override string Description => "The target is taunted into a rage that allows it to use only attack moves for three turns.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Dark;
		public override bool IgnoresProtect => false;
		public Taunt()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}