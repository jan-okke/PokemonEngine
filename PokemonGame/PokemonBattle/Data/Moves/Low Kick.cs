using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Lowkick : Move
	{
		public override string Name => "Low Kick";
		public override string Description => "A powerful low kick that makes the foe fall over. It inflicts greater damage on heavier foes.";
		public override int BasePower => 1;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public Lowkick()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}