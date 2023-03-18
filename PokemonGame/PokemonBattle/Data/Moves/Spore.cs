using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Spore : Move
	{
		public override string Name => "Spore";
		public override string Description => "The user scatters bursts of spores that induce sleep.";
		public override int BasePower => 0;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Grass;
		public override bool IgnoresProtect => false;
		public override bool IsPowderMove => true;
		public Spore()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}