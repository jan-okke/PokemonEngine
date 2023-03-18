using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Thundershock : Move
	{
		public override string Name => "Thunder Shock";
		public override string Description => "A jolt of electricity is hurled at the foe to inflict damage. It may also leave the target with paralysis.";
		public override int BasePower => 40;
		public override int PowerPoints => 30;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Electric;
		public override bool IgnoresProtect => false;
		public Thundershock()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}