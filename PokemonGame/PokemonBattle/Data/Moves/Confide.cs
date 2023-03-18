using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Confide : Move
	{
		public override string Name => "Confide";
		public override string Description => "The user tells the target a secret. The target loses focus and its Sp. Atk stat is lowered.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IsSoundMove => true;
		public Confide()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}