using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Rollingkick : Move
	{
		public override string Name => "Rolling Kick";
		public override string Description => "The user lashes out with a quick, spinning kick. It may also make the target flinch.";
		public override int BasePower => 60;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public Rollingkick()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}