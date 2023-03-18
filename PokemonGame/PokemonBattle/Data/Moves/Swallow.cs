using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Swallow : Move
	{
		public override string Name => "Swallow";
		public override string Description => "The power stored using the move Stockpile is absorbed by the user to heal its HP.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Swallow()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}