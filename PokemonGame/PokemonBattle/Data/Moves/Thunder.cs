using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Thunder : Move
	{
		public override string Name => "Thunder";
		public override string Description => "A wicked thunderbolt is dropped on the foe to inflict damage. It may also leave the target paralyzed.";
		public override int BasePower => 110;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Electric;
		public Thunder()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}