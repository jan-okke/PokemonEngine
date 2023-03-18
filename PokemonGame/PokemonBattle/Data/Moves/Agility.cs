using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Agility : Move
	{
		public override string Name => "Agility";
		public override string Description => "The user relaxes and lightens its body to move faster. It sharply boosts the Speed stat.";
		public override int BasePower => 0;
		public override int PowerPoints => 30;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Psychic;
		public Agility()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}