using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Megapunch : Move
	{
		public override string Name => "Mega Punch";
		public override string Description => "The target is slugged by a punch thrown with muscle-packed power.";
		public override int BasePower => 80;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public Megapunch()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}