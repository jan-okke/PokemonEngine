using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Nightmare : Move
	{
		public override string Name => "Nightmare";
		public override string Description => "A sleeping target sees a nightmare that inflicts some damage every turn.";
		public override int BasePower => 0;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Ghost;
		public override bool IgnoresProtect => false;
		public Nightmare()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}