using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Chatter : Move
	{
		public override string Name => "Chatter";
		public override string Description => "The user attacks using a sound wave based on words it has learned. It may also confuse the target.";
		public override int BasePower => 65;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Flying;
		public Chatter()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}