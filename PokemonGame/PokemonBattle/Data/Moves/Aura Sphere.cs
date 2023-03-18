using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Aurasphere : Move
	{
		public override string Name => "Aura Sphere";
		public override string Description => "The user looses a blast of aura power from deep within its body. This move is certain to hit.";
		public override int BasePower => 80;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Fighting;
		public Aurasphere()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}