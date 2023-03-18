using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Icehammer : Move
	{
		public override string Name => "Ice Hammer";
		public override string Description => "The user swings and hits with its strong, heavy fist. It lowers the user's Speed, however.";
		public override int BasePower => 100;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ice;
		public Icehammer()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}