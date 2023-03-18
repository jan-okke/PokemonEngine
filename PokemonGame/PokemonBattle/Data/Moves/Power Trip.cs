using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Powertrip : Move
	{
		public override string Name => "Power Trip";
		public override string Description => "The user boasts of its strength. Power increases the more the user's stats are raised.";
		public override int BasePower => 1;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Dark;
		public Powertrip()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}