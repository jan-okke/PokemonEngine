using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Aeroblast : Move
	{
		public override string Name => "Aeroblast";
		public override string Description => "A vortex of air is shot at the target to inflict damage. Critical hits land more easily.";
		public override int BasePower => 100;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Flying;
		public Aeroblast()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}