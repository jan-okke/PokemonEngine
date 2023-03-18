using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Razorwind : Move
	{
		public override string Name => "Razor Wind";
		public override string Description => "A two-turn attack. Blades of wind hit the foe on the second turn. Critical hits land more easily.";
		public override int BasePower => 80;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Normal;
		public Razorwind()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}