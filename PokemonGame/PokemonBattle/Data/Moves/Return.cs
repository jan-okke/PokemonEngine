using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Return : Move
	{
		public override string Name => "Return";
		public override string Description => "A full-power attack that grows more powerful the more the user likes its Trainer.";
		public override int BasePower => 1;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public Return()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}