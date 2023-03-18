using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Reflect : Move
	{
		public override string Name => "Reflect";
		public override string Description => "A wondrous wall of light is put up to suppress damage from physical attacks for five turns.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Psychic;
		public Reflect()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}