using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Electrify : Move
	{
		public override string Name => "Electrify";
		public override string Description => "If the target uses a move after being electrified, that move becomes Electric-type.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Electric;
		public override bool IgnoresProtect => false;
		public Electrify()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}