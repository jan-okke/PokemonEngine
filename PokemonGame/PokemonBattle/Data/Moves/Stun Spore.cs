using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Stunspore : Move
	{
		public override string Name => "Stun Spore";
		public override string Description => "The user scatters a cloud of paralyzing powder. It may leave the target with paralysis.";
		public override int BasePower => 0;
		public override int PowerPoints => 30;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Grass;
		public Stunspore()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}