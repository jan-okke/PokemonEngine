using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Grassyterrain : Move
	{
		public override string Name => "Grassy Terrain";
		public override string Description => "The user turns the ground to grass for five turns. Grounded Pokémon restore a little HP every turn.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.BothSides;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Grass;
		public Grassyterrain()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}