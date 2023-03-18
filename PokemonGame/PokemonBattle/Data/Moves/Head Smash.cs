using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Headsmash : Move
	{
		public override string Name => "Head Smash";
		public override string Description => "The user attacks the foe with a hazardous, full-power headbutt. The user also takes terrible damage.";
		public override int BasePower => 150;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Rock;
		public Headsmash()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}