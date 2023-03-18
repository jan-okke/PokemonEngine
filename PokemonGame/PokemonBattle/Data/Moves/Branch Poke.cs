using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Branchpoke : Move
	{
		public override string Name => "Branch Poke";
		public override string Description => "The user attacks the target by poking it with a sharply pointed branch.";
		public override int BasePower => 40;
		public override int PowerPoints => 40;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Grass;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public override bool CanMetronome => false;
		public Branchpoke()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}