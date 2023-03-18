using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Extremespeed : Move
	{
		public override string Name => "Extreme Speed";
		public override string Description => "The user charges the target at blinding speed. This attack always goes before any other move.";
		public override int BasePower => 80;
		public override int PowerPoints => 5;
		public override int Priority => 2;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public Extremespeed()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}