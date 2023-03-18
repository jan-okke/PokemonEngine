using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Wish : Move
	{
		public override string Name => "Wish";
		public override string Description => "One turn after this move is used, the target's HP is restored by half the user's maximum HP.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Wish()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}