using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Poweruppunch : Move
	{
		public override string Name => "Power-Up Punch";
		public override string Description => "Striking opponents repeatedly makes the user's fists harder, raising the user's Attack stat.";
		public override int BasePower => 40;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public Poweruppunch()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}