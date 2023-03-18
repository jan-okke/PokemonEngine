using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Voltswitch : Move
	{
		public override string Name => "Volt Switch";
		public override string Description => "After making its attack, the user rushes back to switch places with a party Pokémon in waiting.";
		public override int BasePower => 70;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Electric;
		public override bool IgnoresProtect => false;
		public Voltswitch()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}