using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Harden : Move
	{
		public override string Name => "Harden";
		public override string Description => "The user stiffens all the muscles in its body to raise its Defense stat.";
		public override int BasePower => 0;
		public override int PowerPoints => 30;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Harden()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}