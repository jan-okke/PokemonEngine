using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Fusionflare : Move
	{
		public override string Name => "Fusion Flare";
		public override string Description => "The user brings down a giant flame. It does more damage if influenced by an enormous thunderbolt.";
		public override int BasePower => 100;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Fire;
		public Fusionflare()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}