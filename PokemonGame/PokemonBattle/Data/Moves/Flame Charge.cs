using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Flamecharge : Move
	{
		public override string Name => "Flame Charge";
		public override string Description => "The user cloaks itself in flame and attacks. Building up more power, it raises the user's Speed stat.";
		public override int BasePower => 50;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Fire;
		public Flamecharge()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}