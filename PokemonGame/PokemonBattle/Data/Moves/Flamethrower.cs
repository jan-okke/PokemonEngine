using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Flamethrower : Move
	{
		public override string Name => "Flamethrower";
		public override string Description => "The target is scorched with an intense blast of fire. It may also leave the target with a burn.";
		public override int BasePower => 90;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Fire;
		public Flamethrower()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}