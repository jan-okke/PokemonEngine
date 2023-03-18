using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Jawlock : Move
	{
		public override string Name => "Jaw Lock";
		public override string Description => "This move prevents the user and the target from switching out until either of them faints.";
		public override int BasePower => 80;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 100;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Dark;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Jawlock()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}