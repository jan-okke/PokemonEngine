using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Clearsmog : Move
	{
		public override string Name => "Clear Smog";
		public override string Description => "The user attacks by throwing a clump of special mud. All status changes are returned to normal.";
		public override int BasePower => 50;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Poison;
		public override bool IgnoresProtect => false;
		public Clearsmog()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}