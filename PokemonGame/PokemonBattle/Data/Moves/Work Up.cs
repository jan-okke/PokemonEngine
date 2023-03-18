using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Workup : Move
	{
		public override string Name => "Work Up";
		public override string Description => "The user is roused, and its Attack and Sp. Atk stats increase.";
		public override int BasePower => 0;
		public override int PowerPoints => 30;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.User;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Workup()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}