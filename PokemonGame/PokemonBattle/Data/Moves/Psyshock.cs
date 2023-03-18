using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Psyshock : Move
	{
		public override string Name => "Psyshock";
		public override string Description => "The user materializes an odd psychic wave to attack the target. This attack does physical damage.";
		public override int BasePower => 80;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Psychic;
		public Psyshock()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}