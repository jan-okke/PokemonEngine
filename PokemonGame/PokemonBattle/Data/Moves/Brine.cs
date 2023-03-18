using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Brine : Move
	{
		public override string Name => "Brine";
		public override string Description => "If the target's HP is down to about half, this attack will hit with double the power.";
		public override int BasePower => 65;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Water;
		public override bool IgnoresProtect => false;
		public Brine()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}