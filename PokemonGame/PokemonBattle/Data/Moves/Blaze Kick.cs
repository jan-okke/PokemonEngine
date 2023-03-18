using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Blazekick : Move
	{
		public override string Name => "Blaze Kick";
		public override string Description => "The user launches a kick with a high critical-hit ratio. It may also leave the target with a burn.";
		public override int BasePower => 85;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fire;
		public Blazekick()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}