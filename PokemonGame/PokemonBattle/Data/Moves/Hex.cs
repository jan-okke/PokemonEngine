using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Hex : Move
	{
		public override string Name => "Hex";
		public override string Description => "This relentless attack does massive damage to a target affected by status problems.";
		public override int BasePower => 65;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Ghost;
		public override bool IgnoresProtect => false;
		public Hex()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}