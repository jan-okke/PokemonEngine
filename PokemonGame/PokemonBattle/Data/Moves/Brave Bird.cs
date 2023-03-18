using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Bravebird : Move
	{
		public override string Name => "Brave Bird";
		public override string Description => "The user tucks in its wings and charges from a low altitude. The user also takes serious damage.";
		public override int BasePower => 120;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Flying;
		public Bravebird()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}