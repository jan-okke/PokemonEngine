using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Topsyturvy : Move
	{
		public override string Name => "Topsy-Turvy";
		public override string Description => "All stat changes affecting the target turn topsy-turvy and become the opposite of what they were.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Dark;
		public override bool IgnoresProtect => false;
		public Topsyturvy()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}