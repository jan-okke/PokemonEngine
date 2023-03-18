using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Boomburst : Move
	{
		public override string Name => "Boomburst";
		public override string Description => "The user attacks everything around it with the destructive power of a terrible, explosive sound.";
		public override int BasePower => 140;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Normal;
		public Boomburst()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}