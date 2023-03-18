using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Scald : Move
	{
		public override string Name => "Scald";
		public override string Description => "The user shoots boiling hot water at its target. It may also leave the target with a burn.";
		public override int BasePower => 80;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Water;
		public Scald()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}