using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Overdrive : Move
	{
		public override string Name => "Overdrive";
		public override string Description => "The user attacks all foes by twanging a guitar or bass guitar, causing a huge echo and strong vibration.";
		public override int BasePower => 80;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Electric;
		public override bool IgnoresProtect => false;
		public override bool IsSoundMove => true;
		public override bool CanMetronome => false;
		public Overdrive()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}