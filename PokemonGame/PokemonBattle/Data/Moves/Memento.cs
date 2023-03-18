using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Memento : Move
	{
		public override string Name => "Memento";
		public override string Description => "The user faints when using this move. In return, it harshly lowers the target's Attack and Sp. Atk.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Dark;
		public Memento()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}