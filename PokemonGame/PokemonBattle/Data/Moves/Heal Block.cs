using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Healblock : Move
	{
		public override string Name => "Heal Block";
		public override string Description => "For five turns, the foe is prevented from using any moves, Abilities, or held items that recover HP.";
		public override int BasePower => 0;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Psychic;
		public Healblock()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}