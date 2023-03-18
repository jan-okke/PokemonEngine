using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Mimic : Move
	{
		public override string Name => "Mimic";
		public override string Description => "The user copies the move last used by the foe. The move can be used until the user is switched out.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IgnoresProtect => false;
		public Mimic()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}