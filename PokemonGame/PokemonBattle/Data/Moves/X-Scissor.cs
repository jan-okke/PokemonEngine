using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Xscissor : Move
	{
		public override string Name => "X-Scissor";
		public override string Description => "The user slashes at the foe by crossing its scythes or claws as if they were a pair of scissors.";
		public override int BasePower => 80;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Bug;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Xscissor()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}