using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Thunderfang : Move
	{
		public override string Name => "Thunder Fang";
		public override string Description => "The user bites with electrified fangs. It may also make the target flinch or leave it with paralysis.";
		public override int BasePower => 65;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Electric;
		public Thunderfang()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}