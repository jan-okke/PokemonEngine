using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Silverwind : Move
	{
		public override string Name => "Silver Wind";
		public override string Description => "The foe is attacked with powdery scales blown by wind. It may also raise all the user's stats.";
		public override int BasePower => 60;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Bug;
		public Silverwind()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}