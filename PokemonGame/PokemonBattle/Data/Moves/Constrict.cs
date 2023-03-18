using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Constrict : Move
	{
		public override string Name => "Constrict";
		public override string Description => "The foe is attacked with long, creeping tentacles or vines. It may also lower the target's Speed.";
		public override int BasePower => 10;
		public override int PowerPoints => 35;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public Constrict()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}