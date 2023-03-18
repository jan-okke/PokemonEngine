using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Dragonhammer : Move
	{
		public override string Name => "Dragon Hammer";
		public override string Description => "The user uses its body like a hammer to attack the target and inflict damage.";
		public override int BasePower => 90;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Dragon;
		public Dragonhammer()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}