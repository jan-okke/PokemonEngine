using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Focusenergy : Move
	{
		public override string Name => "Focus Energy";
		public override string Description => "The user takes a deep breath and focuses so that critical hits land more easily.";
		public override int BasePower => 0;
		public override int PowerPoints => 30;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Focusenergy()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}