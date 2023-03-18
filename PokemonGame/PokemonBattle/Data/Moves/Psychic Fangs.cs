using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Psychicfangs : Move
	{
		public override string Name => "Psychic Fangs";
		public override string Description => "The user bites the target using psychic capabilities. This can also destroy Light Screen and Reflect.";
		public override int BasePower => 85;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Psychic;
		public Psychicfangs()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}