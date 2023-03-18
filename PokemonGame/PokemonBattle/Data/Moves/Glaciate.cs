using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Glaciate : Move
	{
		public override string Name => "Glaciate";
		public override string Description => "The user attacks by blowing freezing cold air at the foe. This attack reduces the targets' Speed stat.";
		public override int BasePower => 65;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Ice;
		public Glaciate()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}