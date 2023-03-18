using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Beakblast : Move
	{
		public override string Name => "Beak Blast";
		public override string Description => "The user heats up its beak before attacking. Making contact in this time results in a burn.";
		public override int BasePower => 100;
		public override int PowerPoints => 15;
		public override int Priority => -3;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Flying;
		public Beakblast()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}