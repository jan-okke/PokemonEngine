using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Scratch : Move
	{
		public override string Name => "Scratch";
		public override string Description => "Hard, pointed, and sharp claws rake the target to inflict damage.";
		public override int BasePower => 40;
		public override int PowerPoints => 35;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public Scratch()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}