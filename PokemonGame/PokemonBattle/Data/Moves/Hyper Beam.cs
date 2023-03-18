using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Hyperbeam : Move
	{
		public override string Name => "Hyper Beam";
		public override string Description => "The foe is attacked with a powerful beam. The user must rest on the next turn to regain its energy.";
		public override int BasePower => 150;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IgnoresProtect => false;
		public Hyperbeam()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}