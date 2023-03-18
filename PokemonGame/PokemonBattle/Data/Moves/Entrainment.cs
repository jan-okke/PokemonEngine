using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Entrainment : Move
	{
		public override string Name => "Entrainment";
		public override string Description => "The user dances to compel the target to mimic it, making the target's Ability the same as the user's.";
		public override int BasePower => 0;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IgnoresProtect => false;
		public Entrainment()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}