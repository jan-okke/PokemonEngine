using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Eerieimpulse : Move
	{
		public override string Name => "Eerie Impulse";
		public override string Description => "The user's body generates an eerie impulse. Harshly lowers the target's Sp. Atk stat.";
		public override int BasePower => 0;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Electric;
		public override bool IgnoresProtect => false;
		public Eerieimpulse()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}