using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Swagger : Move
	{
		public override string Name => "Swagger";
		public override string Description => "The user enrages and confuses the target. However, it also sharply raises the target's Attack stat.";
		public override int BasePower => 0;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IgnoresProtect => false;
		public Swagger()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}