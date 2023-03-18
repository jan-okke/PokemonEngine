using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Judgment : Move
	{
		public override string Name => "Judgment";
		public override string Description => "The user releases countless shots of light. Its type varies with the kind of Plate the user is holding.";
		public override int BasePower => 100;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IgnoresProtect => false;
		public Judgment()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}