using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Diamondstorm : Move
	{
		public override string Name => "Diamond Storm";
		public override string Description => "The user whips up a storm of diamonds to damage foes. This may also sharply raise the user's Defense stat.";
		public override int BasePower => 100;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Rock;
		public override bool IgnoresProtect => false;
		public override bool CanMetronome => false;
		public Diamondstorm()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}