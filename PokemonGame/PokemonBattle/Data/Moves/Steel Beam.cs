using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Steelbeam : Move
	{
		public override string Name => "Steel Beam";
		public override string Description => "The user fires a beam of steel that it collected from its entire body. This also damages the user.";
		public override int BasePower => 140;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Steel;
		public Steelbeam()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}