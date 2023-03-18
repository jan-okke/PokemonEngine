using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Covet : Move
	{
		public override string Name => "Covet";
		public override string Description => "The user endearingly approaches the target, then steals the target's held item.";
		public override int BasePower => 60;
		public override int PowerPoints => 25;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public Covet()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}