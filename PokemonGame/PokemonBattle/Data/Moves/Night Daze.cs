using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Nightdaze : Move
	{
		public override string Name => "Night Daze";
		public override string Description => "The user lets loose a pitch-black shock wave at its target. It may also lower the target's accuracy.";
		public override int BasePower => 85;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Dark;
		public Nightdaze()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}