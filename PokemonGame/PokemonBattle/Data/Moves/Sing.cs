using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Sing : Move
	{
		public override string Name => "Sing";
		public override string Description => "A soothing lullaby is sung in a calming voice that puts the target into a deep slumber.";
		public override int BasePower => 0;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Sing()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}