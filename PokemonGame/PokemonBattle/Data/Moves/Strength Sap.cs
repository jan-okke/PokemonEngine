using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Strengthsap : Move
	{
		public override string Name => "Strength Sap";
		public override string Description => "The user restores its HP by the target's Attack stat amount. Then lowers the target's Attack stat.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Grass;
		public Strengthsap()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}