using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Switcheroo : Move
	{
		public override string Name => "Switcheroo";
		public override string Description => "The user trades held items with the target faster than the eye can follow.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Dark;
		public Switcheroo()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}