using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Magicalleaf : Move
	{
		public override string Name => "Magical Leaf";
		public override string Description => "The user scatters curious leaves that chase the target. This attack will not miss.";
		public override int BasePower => 60;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Grass;
		public Magicalleaf()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}