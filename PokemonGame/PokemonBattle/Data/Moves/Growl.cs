using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Growl : Move
	{
		public override string Name => "Growl";
		public override string Description => "The user growls in an endearing way, making the foe less wary. The foe's Attack stat is lowered.";
		public override int BasePower => 0;
		public override int PowerPoints => 40;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IgnoresProtect => false;
		public override bool IsSoundMove => true;
		public Growl()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}