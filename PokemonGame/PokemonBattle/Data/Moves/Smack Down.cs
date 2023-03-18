using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Smackdown : Move
	{
		public override string Name => "Smack Down";
		public override string Description => "The user throws a stone or projectile to attack. A flying Pokémon will fall to the ground when hit.";
		public override int BasePower => 50;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Rock;
		public Smackdown()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}