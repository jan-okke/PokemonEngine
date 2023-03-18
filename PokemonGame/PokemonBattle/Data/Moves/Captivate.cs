using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Captivate : Move
	{
		public override string Name => "Captivate";
		public override string Description => "If it is the opposite gender of the user, the target is charmed into harshly lowering its Sp. Atk stat.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IgnoresProtect => false;
		public Captivate()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}