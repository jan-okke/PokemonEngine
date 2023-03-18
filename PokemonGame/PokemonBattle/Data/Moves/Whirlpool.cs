using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Whirlpool : Move
	{
		public override string Name => "Whirlpool";
		public override string Description => "Traps foes in a violent swirling whirlpool for four to five turns.";
		public override int BasePower => 35;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override int Accuracy => 85;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Water;
		public override bool IgnoresProtect => false;
		public Whirlpool()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}