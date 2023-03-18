using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Icepunch : Move
	{
		public override string Name => "Ice Punch";
		public override string Description => "The target is punched with an icy fist. It may also leave the target frozen.";
		public override int BasePower => 75;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ice;
		public Icepunch()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}