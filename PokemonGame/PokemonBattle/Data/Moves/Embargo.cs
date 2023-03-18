using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Embargo : Move
	{
		public override string Name => "Embargo";
		public override string Description => "It prevents the target from using its held item. Its Trainer is also prevented from using items on it.";
		public override int BasePower => 0;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Dark;
		public override bool IgnoresProtect => false;
		public Embargo()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}