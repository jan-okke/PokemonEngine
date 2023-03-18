using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Lashout : Move
	{
		public override string Name => "Lash Out";
		public override string Description => "The user lashes out to vent its frustration. Power is doubled if its stats dropped this turn.";
		public override int BasePower => 75;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Dark;
		public Lashout()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}