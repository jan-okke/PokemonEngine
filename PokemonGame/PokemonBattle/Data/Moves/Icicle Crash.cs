using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Iciclecrash : Move
	{
		public override string Name => "Icicle Crash";
		public override string Description => "The user attacks by harshly dropping an icicle onto the foe. It may also make the target flinch.";
		public override int BasePower => 85;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ice;
		public Iciclecrash()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}