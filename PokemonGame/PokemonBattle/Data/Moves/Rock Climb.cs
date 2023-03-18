using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Rockclimb : Move
	{
		public override string Name => "Rock Climb";
		public override string Description => "The user attacks the target by smashing into it with incredible force. It may also confuse the target.";
		public override int BasePower => 90;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override int Accuracy => 85;
		public override int EffectChance => 20;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Rockclimb()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}