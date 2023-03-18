using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Closecombat : Move
	{
		public override string Name => "Close Combat";
		public override string Description => "The user fights the foe up close without guarding itself. It also cuts the user's Defense and Sp. Def.";
		public override int BasePower => 120;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fighting;
		public Closecombat()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}