using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Bulletseed : Move
	{
		public override string Name => "Bullet Seed";
		public override string Description => "The user forcefully shoots seeds at the target. Two to five seeds are shot in rapid succession.";
		public override int BasePower => 25;
		public override int PowerPoints => 30;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Grass;
		public Bulletseed()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}