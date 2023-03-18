using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Visegrip : Move
	{
		public override string Name => "Vise Grip";
		public override string Description => "The target is gripped and squeezed from both sides to inflict damage.";
		public override int BasePower => 55;
		public override int PowerPoints => 30;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public Visegrip()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}