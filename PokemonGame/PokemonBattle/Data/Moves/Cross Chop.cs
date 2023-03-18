using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Crosschop : Move
	{
		public override string Name => "Cross Chop";
		public override string Description => "The user delivers a double chop with its forearms crossed. Critical hits land more easily.";
		public override int BasePower => 100;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public Crosschop()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}