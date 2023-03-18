using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Eruption : Move
	{
		public override string Name => "Eruption";
		public override string Description => "The user attacks in an explosive fury. The lower the user's HP, the less powerful this attack becomes.";
		public override int BasePower => 150;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Fire;
		public override bool IgnoresProtect => false;
		public Eruption()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}