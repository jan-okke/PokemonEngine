using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Instruct : Move
	{
		public override string Name => "Instruct";
		public override string Description => "The user instructs the target to use the target's last move again.";
		public override int BasePower => 0;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Psychic;
		public Instruct()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}