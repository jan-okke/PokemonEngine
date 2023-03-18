using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Waterpulse : Move
	{
		public override string Name => "Water Pulse";
		public override string Description => "The user attacks the target with a pulsing blast of water. It may also confuse the target.";
		public override int BasePower => 60;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Water;
		public override bool IgnoresProtect => false;
		public override bool IsPulseMove => true;
		public Waterpulse()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}