using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Powersplit : Move
	{
		public override string Name => "Power Split";
		public override string Description => "The user employs its psychic power to average its Attack and Sp. Atk stats with those of the target.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Psychic;
		public override bool IgnoresProtect => false;
		public Powersplit()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}