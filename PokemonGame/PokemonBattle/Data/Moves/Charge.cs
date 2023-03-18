using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Charge : Move
	{
		public override string Name => "Charge";
		public override string Description => "The user boosts the power of the Electric move it uses next. It also raises the user's Sp. Def stat.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Electric;
		public Charge()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}