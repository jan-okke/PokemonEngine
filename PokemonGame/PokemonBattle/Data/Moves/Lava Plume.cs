using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Lavaplume : Move
	{
		public override string Name => "Lava Plume";
		public override string Description => "An inferno of scarlet flames torches everything around the user. It may leave targets with a burn.";
		public override int BasePower => 80;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Fire;
		public override bool IgnoresProtect => false;
		public Lavaplume()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}