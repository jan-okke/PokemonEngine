using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Skittersmack : Move
	{
		public override string Name => "Skitter Smack";
		public override string Description => "The user skitters behind the target to attack. This also lowers the target's Sp. Atk stat.";
		public override int BasePower => 70;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Bug;
		public Skittersmack()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}