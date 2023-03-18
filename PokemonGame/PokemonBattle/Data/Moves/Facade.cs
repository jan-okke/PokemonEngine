using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Facade : Move
	{
		public override string Name => "Facade";
		public override string Description => "An attack move that doubles its power if the user is poisoned, burned, or has paralysis.";
		public override int BasePower => 70;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public Facade()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}