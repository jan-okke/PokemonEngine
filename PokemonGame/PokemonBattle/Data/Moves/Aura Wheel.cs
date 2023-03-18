using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Aurawheel : Move
	{
		public override string Name => "Aura Wheel";
		public override string Description => "Morpeko attacks and raises its Speed with energy stored in its cheeks. Type changes with the user's form.";
		public override int BasePower => 110;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Electric;
		public Aurawheel()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}