using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Recycle : Move
	{
		public override string Name => "Recycle";
		public override string Description => "The user recycles a held item that has been used in battle so it can be used again.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Recycle()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}