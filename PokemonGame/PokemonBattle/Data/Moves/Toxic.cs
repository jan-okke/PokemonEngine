using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Toxic : Move
	{
		public override string Name => "Toxic";
		public override string Description => "A move that leaves the target badly poisoned. Its poison damage worsens every turn.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Poison;
		public override bool IgnoresProtect => false;
		public Toxic()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}