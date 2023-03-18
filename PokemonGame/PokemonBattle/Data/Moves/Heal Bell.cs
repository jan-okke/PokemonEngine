using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Healbell : Move
	{
		public override string Name => "Heal Bell";
		public override string Description => "The user makes a soothing bell chime to heal the status problems of all the party Pokémon.";
		public override int BasePower => 0;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Healbell()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}