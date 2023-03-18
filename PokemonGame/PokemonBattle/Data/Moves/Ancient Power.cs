using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Ancientpower : Move
	{
		public override string Name => "Ancient Power";
		public override string Description => "The user attacks with a prehistoric power. It may also raise all the user's stats at once.";
		public override int BasePower => 60;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Rock;
		public override bool IgnoresProtect => false;
		public Ancientpower()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}