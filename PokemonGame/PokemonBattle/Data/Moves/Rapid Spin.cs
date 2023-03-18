using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Rapidspin : Move
	{
		public override string Name => "Rapid Spin";
		public override string Description => "A spin attack that raises the user's Speed and eliminates the effects of Bind, Spikes, etc.";
		public override int BasePower => 50;
		public override int PowerPoints => 40;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public Rapidspin()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}