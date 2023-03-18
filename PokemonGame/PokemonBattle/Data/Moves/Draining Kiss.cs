using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Drainingkiss : Move
	{
		public override string Name => "Draining Kiss";
		public override string Description => "The user steals the target's HP with a kiss. The user's HP is restored by over half of the damage dealt.";
		public override int BasePower => 50;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Fairy;
		public Drainingkiss()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}