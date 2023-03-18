using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Tripleaxel : Move
	{
		public override string Name => "Triple Axel";
		public override string Description => "A consecutive three-kick attack that becomes more powerful with each successful hit.";
		public override int BasePower => 20;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ice;
		public Tripleaxel()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}