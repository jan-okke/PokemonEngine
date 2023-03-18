using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Leaftornado : Move
	{
		public override string Name => "Leaf Tornado";
		public override string Description => "The user attacks its foe by encircling it in sharp leaves. This attack may also lower the foe's accuracy.";
		public override int BasePower => 65;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Grass;
		public Leaftornado()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}