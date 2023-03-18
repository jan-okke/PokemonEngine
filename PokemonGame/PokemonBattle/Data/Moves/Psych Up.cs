using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Psychup : Move
	{
		public override string Name => "Psych Up";
		public override string Description => "The user hypnotizes itself into copying any stat change made by the target.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Psychup()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}