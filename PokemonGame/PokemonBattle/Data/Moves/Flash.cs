using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Flash : Move
	{
		public override string Name => "Flash";
		public override string Description => "The user flashes a light that cuts the target's accuracy. It can also be used to illuminate caves.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Flash()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}