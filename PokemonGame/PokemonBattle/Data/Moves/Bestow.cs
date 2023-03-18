using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Bestow : Move
	{
		public override string Name => "Bestow";
		public override string Description => "The user passes its held item to the target when the target isn't holding an item.";
		public override int BasePower => 0;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Bestow()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}