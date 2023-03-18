using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Spiritbreak : Move
	{
		public override string Name => "Spirit Break";
		public override string Description => "The user attacks the target with immense force. This also lowers the target's Sp. Atk stat.";
		public override int BasePower => 75;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fairy;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public override bool CanMetronome => false;
		public Spiritbreak()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}