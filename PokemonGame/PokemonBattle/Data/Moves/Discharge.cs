using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Discharge : Move
	{
		public override string Name => "Discharge";
		public override string Description => "A flare of electricity is loosed to strike the area around the user. It may also cause paralysis.";
		public override int BasePower => 80;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Electric;
		public Discharge()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}