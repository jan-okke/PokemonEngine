using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Firefang : Move
	{
		public override string Name => "Fire Fang";
		public override string Description => "The user bites with flame-cloaked fangs. It may also make the target flinch or leave it burned.";
		public override int BasePower => 65;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fire;
		public Firefang()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}