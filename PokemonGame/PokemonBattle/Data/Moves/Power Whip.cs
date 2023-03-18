using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Powerwhip : Move
	{
		public override string Name => "Power Whip";
		public override string Description => "The user violently whirls its vines or tentacles to harshly lash the target.";
		public override int BasePower => 120;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Grass;
		public Powerwhip()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}