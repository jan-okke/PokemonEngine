using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Strangesteam : Move
	{
		public override string Name => "Strange Steam";
		public override string Description => "The user attacks the target by emitting steam. This may also confuse the target.";
		public override int BasePower => 90;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Fairy;
		public override bool IgnoresProtect => false;
		public override bool CanMetronome => false;
		public Strangesteam()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}