using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Quash : Move
	{
		public override string Name => "Quash";
		public override string Description => "The user suppresses the target and makes its move go last.";
		public override int BasePower => 0;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Dark;
		public Quash()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}