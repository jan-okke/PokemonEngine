using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Razorleaf : Move
	{
		public override string Name => "Razor Leaf";
		public override string Description => "Sharp-edged leaves are launched to slash at the opposing team. Critical hits land more easily.";
		public override int BasePower => 55;
		public override int PowerPoints => 25;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Grass;
		public Razorleaf()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}