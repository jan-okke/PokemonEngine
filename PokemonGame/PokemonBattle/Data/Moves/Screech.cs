using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Screech : Move
	{
		public override string Name => "Screech";
		public override string Description => "An earsplitting screech harshly reduces the target's Defense stat.";
		public override int BasePower => 0;
		public override int PowerPoints => 40;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Screech()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}