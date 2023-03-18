using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Magnetrise : Move
	{
		public override string Name => "Magnet Rise";
		public override string Description => "The user levitates using electrically generated magnetism for five turns.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Electric;
		public Magnetrise()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}