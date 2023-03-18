using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Chargebeam : Move
	{
		public override string Name => "Charge Beam";
		public override string Description => "The user fires a concentrated bundle of electricity. It may also raise the user's Sp. Atk stat.";
		public override int BasePower => 50;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Electric;
		public Chargebeam()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}