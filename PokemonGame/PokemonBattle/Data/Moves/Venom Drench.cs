using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Venomdrench : Move
	{
		public override string Name => "Venom Drench";
		public override string Description => "Foes are drenched in an odd liquid that lowers the Attack, Sp. Atk, and Speed of poisoned Pokémon.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Poison;
		public Venomdrench()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}