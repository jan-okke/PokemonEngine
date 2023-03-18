using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Confuseray : Move
	{
		public override string Name => "Confuse Ray";
		public override string Description => "The target is exposed to a sinister ray that triggers confusion.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Ghost;
		public override bool IgnoresProtect => false;
		public Confuseray()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}