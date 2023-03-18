using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Meteorbeam : Move
	{
		public override string Name => "Meteor Beam";
		public override string Description => "Gathers space power and boosts its Sp. Atk stat on the first turn, attacks on the next turn.";
		public override int BasePower => 120;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Rock;
		public override bool IgnoresProtect => false;
		public Meteorbeam()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}