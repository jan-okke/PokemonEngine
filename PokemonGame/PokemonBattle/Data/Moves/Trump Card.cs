using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Trumpcard : Move
	{
		public override string Name => "Trump Card";
		public override string Description => "The fewer PP this move has, the greater its attack power.";
		public override int BasePower => 1;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Trumpcard()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}