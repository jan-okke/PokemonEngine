using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Spotlight : Move
	{
		public override string Name => "Spotlight";
		public override string Description => "The user shines a spotlight on the target so that only it will be attacked during the turn.";
		public override int BasePower => 0;
		public override int PowerPoints => 15;
		public override int Priority => 3;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IgnoresProtect => false;
		public Spotlight()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}