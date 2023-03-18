using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Triattack : Move
	{
		public override string Name => "Tri Attack";
		public override string Description => "The user strikes with a simultaneous three-beam attack. May also paralyze, burn, or freeze the target.";
		public override int BasePower => 80;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Normal;
		public Triattack()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}