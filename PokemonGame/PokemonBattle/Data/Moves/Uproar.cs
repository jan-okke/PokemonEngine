using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Uproar : Move
	{
		public override string Name => "Uproar";
		public override string Description => "The user attacks in an uproar for three turns. Over that time, no one can fall asleep.";
		public override int BasePower => 90;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Normal;
		public Uproar()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}