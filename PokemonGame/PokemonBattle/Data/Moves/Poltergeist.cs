using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Poltergeist : Move
	{
		public override string Name => "Poltergeist";
		public override string Description => "Attacks the target by controlling its item. The move fails if the target doesn't have an item.";
		public override int BasePower => 110;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ghost;
		public override bool IgnoresProtect => false;
		public Poltergeist()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}