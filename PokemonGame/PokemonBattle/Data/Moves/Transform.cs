using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Transform : Move
	{
		public override string Name => "Transform";
		public override string Description => "The user transforms into a copy of the target right down to having the same move set.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Transform()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}