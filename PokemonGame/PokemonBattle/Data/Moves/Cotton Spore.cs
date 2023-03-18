using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Cottonspore : Move
	{
		public override string Name => "Cotton Spore";
		public override string Description => "The user releases cotton-like spores that cling to the foe, harshly reducing its Speed stat.";
		public override int BasePower => 0;
		public override int PowerPoints => 40;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Grass;
		public Cottonspore()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}