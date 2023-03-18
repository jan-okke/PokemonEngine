using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Imprison : Move
	{
		public override string Name => "Imprison";
		public override string Description => "If the foe knows any move also known by the user, the foe is prevented from using it.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Psychic;
		public Imprison()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}