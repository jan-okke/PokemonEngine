using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Outrage : Move
	{
		public override string Name => "Outrage";
		public override string Description => "The user rampages and attacks for two to three turns. It then becomes confused, however.";
		public override int BasePower => 120;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Dragon;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Outrage()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}