using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Rocksmash : Move
	{
		public override string Name => "Rock Smash";
		public override string Description => "The user attacks with a punch that can shatter a rock. It may also lower the foe's Defense stat.";
		public override int BasePower => 40;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public Rocksmash()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}