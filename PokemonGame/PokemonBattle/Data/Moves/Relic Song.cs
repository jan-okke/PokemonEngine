using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Relicsong : Move
	{
		public override string Name => "Relic Song";
		public override string Description => "An ancient song appeals to the hearts of those listening. It may also induce sleep.";
		public override int BasePower => 75;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IgnoresProtect => false;
		public override bool IsSoundMove => true;
		public override bool CanMetronome => false;
		public Relicsong()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}