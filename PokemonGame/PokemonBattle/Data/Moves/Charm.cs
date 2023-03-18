using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Charm : Move
	{
		public override string Name => "Charm";
		public override string Description => "The user charmingly gazes at the foe, making it less wary. The target's Attack is harshly lowered.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Fairy;
		public override bool IgnoresProtect => false;
		public Charm()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}