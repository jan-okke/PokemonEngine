using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Grassyglide : Move
	{
		public override string Name => "Grassy Glide";
		public override string Description => "Gliding on the ground, the user attacks the target. This move always goes first on Grassy Terrain.";
		public override int BasePower => 70;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Grass;
		public Grassyglide()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}