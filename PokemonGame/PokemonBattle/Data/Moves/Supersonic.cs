using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Supersonic : Move
	{
		public override string Name => "Supersonic";
		public override string Description => "The user generates odd sound waves from its body. It may confuse the target.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IgnoresProtect => false;
		public override bool IsSoundMove => true;
		public Supersonic()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}