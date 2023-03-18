using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Meteorassault : Move
	{
		public override string Name => "Meteor Assault";
		public override string Description => "The user attacks wildly with its thick leek. The user can't move on the next turn.";
		public override int BasePower => 150;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public Meteorassault()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}