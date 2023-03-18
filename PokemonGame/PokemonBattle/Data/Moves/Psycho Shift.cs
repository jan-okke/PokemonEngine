using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Psychoshift : Move
	{
		public override string Name => "Psycho Shift";
		public override string Description => "Using its psychic power of suggestion, the user transfers its status problems to the target.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Psychic;
		public Psychoshift()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}