using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Hiddenpower : Move
	{
		public override string Name => "Hidden Power";
		public override string Description => "A unique attack that varies in type and intensity depending on the Pokémon using it.";
		public override int BasePower => 60;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Normal;
		public Hiddenpower()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}