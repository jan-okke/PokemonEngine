using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Surf : Move
	{
		public override string Name => "Surf";
		public override string Description => "It swamps the area around the user with a giant wave. It can also be used for crossing water.";
		public override int BasePower => 90;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Water;
		public Surf()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}