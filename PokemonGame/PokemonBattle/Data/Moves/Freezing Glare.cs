using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Freezingglare : Move
	{
		public override string Name => "Freezing Glare";
		public override string Description => "The user shoots its psychic power from its eyes to attack. This may also leave the target frozen.";
		public override int BasePower => 90;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Psychic;
		public Freezingglare()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}