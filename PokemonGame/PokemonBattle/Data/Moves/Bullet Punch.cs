using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Bulletpunch : Move
	{
		public override string Name => "Bullet Punch";
		public override string Description => "The user strikes the target with tough punches as fast as bullets. This move always goes first.";
		public override int BasePower => 40;
		public override int PowerPoints => 30;
		public override int Priority => 1;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Steel;
		public Bulletpunch()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}