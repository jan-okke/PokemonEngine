using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Afteryou : Move
	{
		public override string Name => "After You";
		public override string Description => "The user helps the target and makes it use its move right after the user.";
		public override int BasePower => 0;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Afteryou()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}