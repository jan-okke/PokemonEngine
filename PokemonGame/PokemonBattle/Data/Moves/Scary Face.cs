using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Scaryface : Move
	{
		public override string Name => "Scary Face";
		public override string Description => "The user frightens the target with a scary face to harshly reduce its Speed stat.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IgnoresProtect => false;
		public Scaryface()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}