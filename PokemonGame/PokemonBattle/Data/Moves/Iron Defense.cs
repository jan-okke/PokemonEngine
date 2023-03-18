using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Irondefense : Move
	{
		public override string Name => "Iron Defense";
		public override string Description => "The user hardens its body's surface like iron, sharply raising its Defense stat.";
		public override int BasePower => 0;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Steel;
		public Irondefense()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}