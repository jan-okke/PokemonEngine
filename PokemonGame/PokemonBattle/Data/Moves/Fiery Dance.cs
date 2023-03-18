using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Fierydance : Move
	{
		public override string Name => "Fiery Dance";
		public override string Description => "Cloaked in flames, the user dances and flaps its wings. It may also raise the user's Sp. Atk stat.";
		public override int BasePower => 80;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Fire;
		public Fierydance()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}