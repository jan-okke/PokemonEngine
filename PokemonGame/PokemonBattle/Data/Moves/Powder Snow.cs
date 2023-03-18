using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Powdersnow : Move
	{
		public override string Name => "Powder Snow";
		public override string Description => "The user attacks with a chilling gust of powdery snow. It may also freeze the targets.";
		public override int BasePower => 40;
		public override int PowerPoints => 25;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Ice;
		public override bool IgnoresProtect => false;
		public Powdersnow()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}