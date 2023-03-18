using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Torment : Move
	{
		public override string Name => "Torment";
		public override string Description => "The user torments and enrages the foe, making it incapable of using the same move twice in a row.";
		public override int BasePower => 0;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Dark;
		public Torment()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}