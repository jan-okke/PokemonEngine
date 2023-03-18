using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Moonblast : Move
	{
		public override string Name => "Moonblast";
		public override string Description => "The user attacks by borrowing the power of the moon. This may also lower the target's Sp. Atk stat.";
		public override int BasePower => 95;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Fairy;
		public override bool IgnoresProtect => false;
		public Moonblast()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}