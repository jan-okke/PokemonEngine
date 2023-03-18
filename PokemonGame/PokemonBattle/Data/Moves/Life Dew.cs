using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Lifedew : Move
	{
		public override string Name => "Life Dew";
		public override string Description => "The user scatters mysterious water around and restores the HP of itself and its allies.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Water;
		public Lifedew()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}