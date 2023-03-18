using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Psystrike : Move
	{
		public override string Name => "Psystrike";
		public override string Description => "The user materializes an odd psychic wave to attack the target. This attack does physical damage.";
		public override int BasePower => 100;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Psychic;
		public override bool IgnoresProtect => false;
		public Psystrike()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}