using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Mudbomb : Move
	{
		public override string Name => "Mud Bomb";
		public override string Description => "The user launches a hard-packed mud ball to attack. It may also lower the target's accuracy.";
		public override int BasePower => 65;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Ground;
		public Mudbomb()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}