using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Stompingtantrum : Move
	{
		public override string Name => "Stomping Tantrum";
		public override string Description => "The user attacks driven by frustration. Power increases if the user's previous move failed.";
		public override int BasePower => 75;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ground;
		public Stompingtantrum()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}