using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Bind : Move
	{
		public override string Name => "Bind";
		public override string Description => "Things such as long bodies or tentacles are used to bind and squeeze the foe for four to five turns.";
		public override int BasePower => 15;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override int Accuracy => 85;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Bind()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}