using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Leafage : Move
	{
		public override string Name => "Leafage";
		public override string Description => "The user attacks by pelting the target with leaves.";
		public override int BasePower => 40;
		public override int PowerPoints => 40;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Grass;
		public Leafage()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}