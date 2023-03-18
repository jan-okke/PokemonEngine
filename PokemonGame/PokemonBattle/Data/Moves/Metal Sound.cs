using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Metalsound : Move
	{
		public override string Name => "Metal Sound";
		public override string Description => "A horrible sound like scraping metal harshly reduces the target's Sp. Def stat.";
		public override int BasePower => 0;
		public override int PowerPoints => 40;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Steel;
		public Metalsound()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}