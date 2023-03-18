using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Nobleroar : Move
	{
		public override string Name => "Noble Roar";
		public override string Description => "Letting out a noble roar, the user intimidates the target and lowers its Attack and Sp. Atk.";
		public override int BasePower => 0;
		public override int PowerPoints => 30;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Nobleroar()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}