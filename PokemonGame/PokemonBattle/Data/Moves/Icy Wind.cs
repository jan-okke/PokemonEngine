using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Icywind : Move
	{
		public override string Name => "Icy Wind";
		public override string Description => "The user attacks with a gust of chilled air. It also lowers the targets' Speed stat.";
		public override int BasePower => 55;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Ice;
		public override bool IgnoresProtect => false;
		public Icywind()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}