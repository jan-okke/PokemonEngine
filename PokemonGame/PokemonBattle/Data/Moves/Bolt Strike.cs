using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Boltstrike : Move
	{
		public override string Name => "Bolt Strike";
		public override string Description => "The user charges at its foe, surrounding itself with lightning. It may also leave the target paralyzed.";
		public override int BasePower => 130;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Electric;
		public Boltstrike()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}