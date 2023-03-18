using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Bellydrum : Move
	{
		public override string Name => "Belly Drum";
		public override string Description => "The user maximizes its Attack stat in exchange for HP equal to half its max HP.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Bellydrum()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}