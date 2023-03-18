using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Stuffcheeks : Move
	{
		public override string Name => "Stuff Cheeks";
		public override string Description => "The user eats its held Berry, then sharply raises its Defense stat.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Stuffcheeks()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}