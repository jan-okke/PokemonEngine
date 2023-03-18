using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Ember : Move
	{
		public override string Name => "Ember";
		public override string Description => "The target is attacked with small flames. It may also leave the target with a burn.";
		public override int BasePower => 40;
		public override int PowerPoints => 25;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Fire;
		public Ember()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}