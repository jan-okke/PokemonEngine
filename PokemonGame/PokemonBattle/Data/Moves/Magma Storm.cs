using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Magmastorm : Move
	{
		public override string Name => "Magma Storm";
		public override string Description => "The target becomes trapped within a maelstrom of fire that rages for four to five turns.";
		public override int BasePower => 100;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Fire;
		public override bool IgnoresProtect => false;
		public Magmastorm()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}