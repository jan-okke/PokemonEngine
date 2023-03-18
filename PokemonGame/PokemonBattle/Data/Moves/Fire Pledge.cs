using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Firepledge : Move
	{
		public override string Name => "Fire Pledge";
		public override string Description => "A column of fire hits opposing Pokémon. When used with its Grass equivalent, it makes a sea of fire.";
		public override int BasePower => 80;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Fire;
		public Firepledge()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}