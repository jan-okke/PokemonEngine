using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Naturalgift : Move
	{
		public override string Name => "Natural Gift";
		public override string Description => "The user draws power to attack by using its held Berry. The Berry determines its type and power.";
		public override int BasePower => 1;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public Naturalgift()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}