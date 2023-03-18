using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Precipiceblades : Move
	{
		public override string Name => "Precipice Blades";
		public override string Description => "The user attacks its foes by manifesting the power of the land in fearsome blades of stone.";
		public override int BasePower => 120;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ground;
		public Precipiceblades()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}