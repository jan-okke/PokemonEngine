using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Octazooka : Move
	{
		public override string Name => "Octazooka";
		public override string Description => "The user attacks by spraying ink in the foe's face or eyes. It may also lower the target's accuracy.";
		public override int BasePower => 65;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Water;
		public Octazooka()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}