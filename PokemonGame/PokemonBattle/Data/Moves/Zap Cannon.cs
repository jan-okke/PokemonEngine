using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Zapcannon : Move
	{
		public override string Name => "Zap Cannon";
		public override string Description => "The user fires an electric blast like a cannon to inflict damage and cause paralysis.";
		public override int BasePower => 120;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Electric;
		public Zapcannon()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}