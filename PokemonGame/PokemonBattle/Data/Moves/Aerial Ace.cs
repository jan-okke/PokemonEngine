using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Aerialace : Move
	{
		public override string Name => "Aerial Ace";
		public override string Description => "The user confounds the foe with speed, then slashes. The attack lands without fail.";
		public override int BasePower => 60;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Flying;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Aerialace()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}